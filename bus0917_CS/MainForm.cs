using MjpegProcessor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using System.Threading;

namespace bus0917_CS
{
    public partial class MainForm : Form
    {
        MjpegDecoder _mjpeg;
        private String IpAdd = "192.168.0.1";       // private String IpAdd = "192.168.3.11";
        private Ping IpAddress = new Ping();
        PingReply reply;

        private List<string> temp_list;
        private ImageList imageList;
        private List<string> paths;
        private int to_delete = -1;
        private string newest_user;

        loading_form lf = new loading_form();

        [DllImport("TAKEPICTUREDLL.dll", EntryPoint = "TakePicture")]
        private static extern bool TakePicture(string str);

        [DllImport("TAKEPICTUREDLL.dll", EntryPoint = "Convert_PGM_to_JPG")]
        private static extern bool Convert_PGM_to_JPG(string str);

        [DllImport("DLIBTRAINERDLL.dll", EntryPoint = "Check_user")]
        private static extern IntPtr Check_user();

        [DllImport("socket_to_linux_dll.dll", EntryPoint = "Connect_to_send_image")]
        private static extern int Connect_to_send_image(string ip, string file_name);

        [DllImport("socket_to_linux_dll.dll", EntryPoint = "send_dats")]
        private static extern int send_dats(string ip, string calc_file_name, string user_file_name);

        [DllImport("IMAGERECEIVER.dll", EntryPoint = "Create_socket_and_receive_image")]
        private static extern int Create_socket_and_receive_image();

        public MainForm()
        {
            reply = IpAddress.Send(IPAddress.Parse(IpAdd));
            InitializeComponent();

            _mjpeg = new MjpegDecoder();
            _mjpeg.FrameReady += mjpeg_FrameReady;

            label7.Text = DateTime.Now.ToLongTimeString();
            label8.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)                                                            // for every second of tickings
        {
            label7.Text = DateTime.Now.ToLongTimeString();                                                              // display date time on status
            label8.Text = DateTime.Now.ToLongDateString();
            if (reply.Status == IPStatus.Success)                                                                       // get ping status
            {
                updateToolStripMenuItem.Visible = true; updateToolStripMenuItem.Enabled = true;                         // re-enable and make visible update XML button
                label10.Text = IpAdd + "\n And Round Trip Time of the packet is:" + reply.RoundtripTime.ToString();     // get packet travel time
                _mjpeg.ParseStream(new Uri("http://" + IpAdd + ":8080/?action=stream"));                                // show video-stream
            }
            else
            {
                updateToolStripMenuItem.Visible = false; updateToolStripMenuItem.Enabled = false;                       // re-disable and unmake visible update XML button
                label10.Text = "Not Connected." + Environment.NewLine + "Please Check: Menu -> IP Config";              // re-set status bar and display error msg
                _mjpeg.StopStream();                                                                                    // stop video-stream
                this.pictureBox1.Image = Properties.Resources.error404;
            }

            if (lf.successFlag == true)
            {
                ((Control)this.FunctionsTabControl).Enabled = true;
            }
        }

        //Menu Bar Controls
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iPConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            input_ip_box iib = new input_ip_box(IpAdd);
            if (DialogResult.OK == iib.ShowDialog())
            {
                IpAdd = iib.get_ip();
                reply = IpAddress.Send(IPAddress.Parse(iib.get_ip()));
                label10.Text = IpAdd;
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connect_to_send_image(IpAdd, "dlib_data/calc_script.dat");
            Thread.Sleep(1000);
            Connect_to_send_image(IpAdd, "dlib_data/users.dat");
        }

        //Take  Function Controls
        private Image GetImage(string fileName)
        {
            byte[] bytes = File.ReadAllBytes(fileName);
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void show_result_picture(string username)
        {
            imageList = new ImageList();
            this.takePicListView.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo("temp_data_" + username);
            paths = new List<string>();


            foreach (FileInfo file in dir.GetFiles())
            {
                paths.Add(file.FullName);
                try
                {
                    imageList.Images.Add(GetImage(file.FullName));
                }
                catch (Exception e)
                { takePicLabel.Text += e.ToString() + "\n"; }
            }
            imageList.ImageSize = new Size(92, 112);

            this.takePicListView.View = View.LargeIcon;

            for (int counter = 0; counter < imageList.Images.Count; counter++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = counter;
                this.takePicListView.Items.Add(item);
            }
            this.takePicListView.LargeImageList = imageList;
        }

        private void takePicListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (takePicListView.SelectedItems.Count > 0)
            {
                to_delete = takePicListView.Items.IndexOf(takePicListView.SelectedItems[0]);

                takePicListView.Items.Remove(takePicListView.Items[to_delete]);
                imageList.Images.RemoveAt(to_delete);
                try
                {
                    File.Delete(paths[to_delete]);
                }
                catch (IOException ioe)
                {
                    takePicLabel.Text = ioe.Message;
                }

                int r = Int32.Parse(Path.GetFileNameWithoutExtension(paths[to_delete]));

                if (File.Exists("att_faces/" + newest_user + "/" + r.ToString() + ".PGM"))
                    File.Delete("att_faces/" + newest_user + "/" + r.ToString() + ".PGM");

                if (File.Exists("att_faces/" + newest_user + "/" + r.ToString() + ".pgm"))
                    File.Delete("att_faces/" + newest_user + "/" + r.ToString() + ".pgm");

                takePicLabel.Text = "att_faces/" + newest_user + "/" + r.ToString() + ".pgm";

                paths.RemoveAt(to_delete);
            }
        }

        private void takePicStartButton_Click(object sender, EventArgs e)
        {
            takePicStartButton.Enabled = false;
            StudentIDListComboBox.Enabled = false;
            takePicTextBox.Enabled = false;

            if (StudentIDListComboBox.Text.Equals(string.Empty) || takePicTextBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("學號、檔案名填寫完整", string.Empty, MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                takePicStartButton.Enabled = true;
                StudentIDListComboBox.Enabled = true;
                takePicTextBox.Enabled = true;
                return;
            }
            else if (!StudentIDListComboBox.Items.Contains(StudentIDListComboBox.Text))
            {
                MessageBox.Show("沒有這個學號", string.Empty, MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                takePicStartButton.Enabled = true;
                StudentIDListComboBox.Enabled = true;
                takePicTextBox.Enabled = true;
                return;
            }
            foreach (string f in Directory.GetDirectories(Directory.GetCurrentDirectory()))
                if (f.Contains(takePicTextBox.Text))
                {
                    MessageBox.Show("檔名重複", string.Empty, MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
                    takePicTextBox.Text = string.Empty;
                    takePicStartButton.Enabled = true;
                    StudentIDListComboBox.Enabled = true;
                    takePicTextBox.Enabled = true;
                    return;
                }

            newest_user = takePicTextBox.Text;

            TakePicture(takePicTextBox.Text);
            Convert_PGM_to_JPG(takePicTextBox.Text);
            show_result_picture(takePicTextBox.Text);

            /*
            bool res = TakePicture(takePicTextBox.Text);
            bool con = Convert_PGM_to_JPG(takePicTextBox.Text);
            show_result_picture(takePicTextBox.Text);

            takePicTextBox.Text = "";

            if (res)
            { MessageBox.Show("take pucture success", "Success"); }
            else
            { MessageBox.Show("take picture failure", "Failure"); }
            */

            takePicFinishButton.Enabled = true;
            takePicCancelButton.Enabled = true;
        }

        private void takePicFinishButton_Click(object sender, EventArgs e)
        {
            takePicFinishButton.Enabled = false;
            takePicCancelButton.Enabled = false;

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            string adddata = string.Format("insert into face_info value('{0}','{1}\\{2}','{3}')", takePicTextBox.Text, Directory.GetCurrentDirectory(), takePicTextBox.Text, StudentIDListComboBox.Text).Replace("\\", "\\\\");
            MySqlCommand commandDatabase = new MySqlCommand(adddata, databaseConnection);
            commandDatabase.Connection = databaseConnection;
            commandDatabase.ExecuteNonQuery();
            databaseConnection.Close();

            takePicListView.Items.Clear();
            imageList.Images.Clear();
            paths.Clear();

            if (Directory.Exists("temp_data_" + newest_user))
                Directory.Delete("temp_data_" + newest_user, true);

            addrow("select * from face_info where Face_Id = '"+ takePicTextBox.Text + "'", ((DataGridView)(((TabPage)(DatabaseTabControl.TabPages[1])).Controls[0])));

            takePicTextBox.Text = string.Empty;
            StudentIDListComboBox.Text = string.Empty;

            StudentIDListComboBox.Enabled = true;
            takePicTextBox.Enabled = true;
            takePicStartButton.Enabled = true;
            trainingTrainButton.Enabled = true;
        }

        private void takePicCancelButton_Click(object sender, EventArgs e)
        {
            takePicFinishButton.Enabled = false;
            takePicCancelButton.Enabled = false;

            takePicTextBox.Text = string.Empty;
            takePicListView.Items.Clear();

            if (Directory.Exists("att_faces/" + newest_user))
                Directory.Delete("att_faces/" + newest_user, true);
            if (Directory.Exists("temp_data_" + newest_user))
                Directory.Delete("temp_data_" + newest_user, true);

            StudentIDListComboBox.Text = string.Empty;
            takePicTextBox.Text = string.Empty;
            StudentIDListComboBox.Enabled = true;
            takePicTextBox.Enabled = true;
            takePicStartButton.Enabled = true;
        }


        //Training Function Controls
        private void clear_folder(string folder_name)
        {
            DirectoryInfo dir = new DirectoryInfo(folder_name);

            foreach (FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }
        }

        private void add_new_panel_face_by_list(List<string> name)
        {
            trainingListView.Items.Clear();
            int untrained = 0;
            ImageList untrained_list = new ImageList();
            untrained_list.ImageSize = new Size(92, 112);

            foreach (string filename in name)
            {
                if (!filename.Contains("empty"))
                {
                    untrained++;
                    try
                    {
                        // MessageBox.Show("temp_data/" + filename + ".jpg", "try");
                        untrained_list.Images.Add(GetImage("temp_data/" + filename + ".jpg"));
                    }
                    catch (Exception e)
                    { label2.Text += e.ToString() + "\n"; }

                }
                else
                {
                    MessageBox.Show("user: " + filename.Replace("empty ", "") + " folder is empty", "error");

                }
            }

            name.RemoveAll(it => it.Contains("empty"));


            this.trainingListView.View = View.LargeIcon;
            //MessageBox.Show( untrained_list.Images.Count.ToString() , "count" );
            for (int counter = 0; counter < untrained_list.Images.Count; counter++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = counter;

                //this.trainingListView.Items.Add(item);
                this.trainingListView.Items.Add(name[counter].ToString(), counter);
            }

            this.trainingListView.LargeImageList = untrained_list;
        }

        private void trainingTrainButton_Click(object sender, EventArgs e)
        {
            ((Control)this.FunctionsTabControl).Enabled = false;

            lf.Show();
            lf.Form_Shown();

            List<Control> delete_list = new List<Control>();

            foreach (Control con in FunctionsTabControl.TabPages[2].Controls)
            {
                if (con is Panel && con.Name.Contains("panel_new_"))
                {
                    delete_list.Add(con);
                }
            }

            for (int c = delete_list.Count - 1; c > -1; --c)
            {
                FunctionsTabControl.TabPages[2].Controls.Remove(delete_list[c]);
            }

            clear_folder("temp_data");
            trainingListView.Items.Clear();
            trainingTitleLabel.Text = "Trained";
            trainingTrainButton.Enabled = false;
        }

        private void FunctionsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FunctionsTabControl.SelectedIndex == 2)
            {
                trainingStatusLabel.Text = "";
                String temp = Marshal.PtrToStringAnsi(Check_user());
                string[] temps = temp.Split(';');
                temp_list = new List<string>(temp.Split(';'));

                List<string> remove_list = new List<string>();
                remove_list.Add("true");
                remove_list.Add("");


                if (temps[0].Equals("false"))
                {
                    MessageBox.Show("Never trained !", "Message");
                    trainingTitleLabel.Text = "Train your data!";
                    trainingTrainButton.Enabled = true;
                }
                else
                {
                    temp_list.RemoveAll(it => "".Equals(it) || "true".Equals(it));
                    trainingStatusLabel.Text = "";
                    foreach (string s in temp_list)
                        trainingStatusLabel.Text += s + ",";

                    if (temp_list.Count == 0)
                    {
                        MessageBox.Show("Nothing for update !", "Nothing change");
                        trainingTrainButton.Enabled = false;
                    }
                    else
                    {
                        add_new_panel_face_by_list(temp_list);
                    }
                }
            }
        }

        //Live Stream Function Controls
        private void mjpeg_FrameReady(object sender, FrameReadyEventArgs e)
        {
            pictureBox1.Image = e.Bitmap;
            //image.Source = e.BitmapImage;
        }

        string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db;sslmode = none;";
        int ScanFaceInfoIndex, ScanCardInfoIndex;//供更新畫面使用
        private void MainForm_Load(object sender, EventArgs e)
        {
            #region 檢查mysql有沒有打開
            MySqlConnection CheckDB = new MySqlConnection(MySQLConnectionString);
            try
            {
                CheckDB.Open();
                CheckDB.Close();
                MySqlConnection.ClearPool(CheckDB);
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message, "SQL錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                Environment.Exit(Environment.ExitCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                Environment.Exit(Environment.ExitCode);
            }
            #endregion

            #region 檢查有無Picture資料夾
            Console.WriteLine(Directory.GetCurrentDirectory());
            if (!Directory.Exists("Picture"))
                Directory.CreateDirectory("Picture");
            #endregion

            using (SQLClass StudentID=new SQLClass("select * from student_info", MySQLConnectionString))
            {
                while(StudentID.Reader.Read())
                    StudentIDListComboBox.Items.Add(StudentID.Reader.GetString(0));
            }


                ColumnListBox.Width = tableLayoutPanel1.Controls[2].Width - 3;
            SearchTextBox.Width = tableLayoutPanel1.Controls[2].Width - 3;
            SearchButton.Width = tableLayoutPanel1.Controls[2].Width - 3;
            DefaultButton.Width = tableLayoutPanel1.Controls[2].Width - 3;
            using (SQLClass initialization = new SQLClass("show tables", MySQLConnectionString))
            {
                while(initialization.Reader.Read())
                {
                    TabPage page = new TabPage();
                    page.Text = initialization.Reader.GetString(0);//page name
                    DatabaseTabControl.TabPages.Add(page);
                    page.Location = new System.Drawing.Point(4, 38);
                    page.Padding = new System.Windows.Forms.Padding(3);
                    page.Size = new System.Drawing.Size(782, 798);
                    page.UseVisualStyleBackColor = true;

                    DataGridView data = new DataGridView();
                    page.Controls.Add(data);
                    data.Location = new System.Drawing.Point(3, 3);
                    data.RowTemplate.Height = 27;
                    data.Size = new System.Drawing.Size(776, 792);
                    data.Dock = System.Windows.Forms.DockStyle.Fill;
                    data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    data.AllowUserToAddRows = false;
                    //添加顯示圖片功能
                    if (String.Compare(page.Text, "Scan_Card_Info",true)==0)
                        data.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DoubleClickShowPictrue);

                    using (SQLClass title = new SQLClass("select column_name from INFORMATION_SCHEMA.COLUMNS where table_name='" + initialization.Reader.GetString(0) + "'", MySQLConnectionString))
                    {
                        while (title.Reader.Read())
                        { 
                            DataGridViewTextBoxColumn Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
                            Column.HeaderText = title.Reader.GetString(0);
                            Column.Name = title.Reader.GetString(0);
                            Column.ReadOnly = true;
                            Column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
                            Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                            data.Columns.AddRange(Column);
                        }
                    }
                    addrow("select * from " + initialization.Reader.GetString(0), data);//讀入資料
                }
            }
            searchListbox(DatabaseTabControl.SelectedIndex);//初始化搜尋欄位
            receiver_backgroundWorker.RunWorkerAsync();

            #region 初始化FileSystemWatcher供更新畫面用
            using (SQLClass ScanFaceInfoCount = new SQLClass("select count(*) from scan_face_info", MySQLConnectionString))
            {
                ScanFaceInfoCount.Reader.Read();
                ScanFaceInfoIndex = ScanFaceInfoCount.Reader.GetInt32(0);
            }
            using (SQLClass ScanCardInfoCount = new SQLClass("select count(*) from scan_card_info", MySQLConnectionString))
            {
                ScanCardInfoCount.Reader.Read();
                ScanCardInfoIndex = ScanCardInfoCount.Reader.GetInt32(0);
            }
            this.ScanFaceInfoWatcher.Changed += new System.IO.FileSystemEventHandler(this.ScanFaceInfoWatcher_Changed);
            this.ScanCardInfoWatcher.Changed += new System.IO.FileSystemEventHandler(this.ScanCardInfoWatcher_Changed);
            this.ScanFaceInfoWatcher.EnableRaisingEvents = true;
            this.ScanCardInfoWatcher.EnableRaisingEvents = true;
            #endregion
        }
        private void addrow(string DbCommand, DataGridView data)
        //DbCommand: Db的指令
        //data: 在哪一個頁面加入row
        {
            using (SQLClass rowData = new SQLClass(DbCommand, MySQLConnectionString))
            {
                while (rowData.Reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(data);
                    for (int index = 0; index < rowData.Reader.FieldCount; index++)
                        row.Cells[index].Value = rowData.Reader.GetString(index);
                    data.Rows.Add(row);
                }
            }
        }

        private void DatabaseTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColumnListBox.Items.Clear();
            searchListbox(DatabaseTabControl.SelectedIndex);
        }
        private void searchListbox(int SelectedTab)
        {
            for (int i = 0; i < ((DataGridView)DatabaseTabControl.Controls[SelectedTab].Controls[0]).ColumnCount; i++)
                ColumnListBox.Items.Add(((DataGridView)DatabaseTabControl.Controls[SelectedTab].Controls[0]).Columns[i].HeaderText);
            ColumnListBox.Height = ColumnListBox.ItemHeight * (ColumnListBox.Items.Count + 1);
        }
        private void SearchButton_Click(object sender, EventArgs e)//搜尋功能
        {
            if (ColumnListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select something in listbox");
                return;
            }
            string tbCol = ColumnListBox.Items[ColumnListBox.SelectedIndex].ToString();
            string search = SearchTextBox.Text;
            foreach (Control con in DatabaseTabControl.Controls)
            {
                string tbName = ((TabPage)con).Text;
                ((DataGridView)con.Controls[0]).Rows.Clear();
                if (((DataGridView)con.Controls[0]).Columns.Contains(tbCol))//先確認page的Column裡面有沒有tbCol
                    addrow("select * from " + tbName + " where " + tbCol + " ='" + search + "'", (DataGridView)con.Controls[0]);
            }
        }

        private void DefaultButton_Click(object sender, EventArgs e)//重置
        {
            foreach (Control con in DatabaseTabControl.Controls)
            {
                ((DataGridView)con.Controls[0]).Rows.Clear();
                string tbName = ((TabPage)con).Text;
                addrow("select * from " + tbName, (DataGridView)con.Controls[0]);
            }
        }
        private void receiver_backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Create_socket_and_receive_image();
        }
        
        private void DoubleClickShowPictrue(object sender, DataGridViewCellMouseEventArgs e)//顯示圖片
        {
            if (((DataGridView)(((TabPage)(DatabaseTabControl.TabPages[2])).Controls[0])).CurrentCell.ColumnIndex == 3)
            {
                if (File.Exists("Picture/" + ((DataGridView)(((TabPage)(DatabaseTabControl.TabPages[2])).Controls[0])).CurrentCell.Value.ToString()))//先看看圖片存不存在
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.FileName = Directory.GetCurrentDirectory() + "/Picture/" + ((DataGridView)(((TabPage)(DatabaseTabControl.TabPages[2])).Controls[0])).CurrentCell.Value.ToString();
                    process.StartInfo.Arguments = "rundll32.exe C://WINDOWS//system32//shimgvw.dll,ImageView_Fullscreen";
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    process.Start();//使用windows的圖片顯示器來顯示圖片
                    process.Close();
                }
                else
                {
                    MessageBox.Show(Directory.GetCurrentDirectory() + "/Picture/" + ((DataGridView)(((TabPage)(DatabaseTabControl.TabPages[2])).Controls[0])).CurrentCell.Value.ToString() + "\n圖片不存在", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ScanFaceInfoWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            addrow("select * from scan_face_info where Face_Record >" + ScanFaceInfoIndex, ((DataGridView)(((TabPage)(DatabaseTabControl.TabPages[3])).Controls[0])));
            //把大於Face_Record的row都加進去
            using (SQLClass CurrentCount = new SQLClass("select count(*) from scan_face_info", MySQLConnectionString))
            {
                CurrentCount.Reader.Read();
                ScanFaceInfoIndex = CurrentCount.Reader.GetInt32(0);
                if (Person_timer.Enabled)
                {
                    Person_timer.Stop();
                }
                Person_timer.Start();
                label_PersonName.Text = ((DataGridView)(((TabPage)(DatabaseTabControl.TabPages[3])).Controls[0])).Rows[ScanFaceInfoIndex - 1].Cells[1].Value.ToString();
            }
        }

        private void Card_timer_Tick(object sender, EventArgs e)
        {
            label_card.Text = "Not Detected";
            Card_timer.Stop();
        }

        private void Person_timer_Tick(object sender, EventArgs e)
        {
            label_PersonName.Text = "Not Detected";
            Person_timer.Stop();
        }

        private void ScanCardInfoWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            addrow("select * from scan_card_info where Card_Record >" + ScanCardInfoIndex, ((DataGridView)(((TabPage)(DatabaseTabControl.TabPages[2])).Controls[0])));
            using (SQLClass CurrentCount = new SQLClass("select count(*) from scan_card_info", MySQLConnectionString))
            {
                CurrentCount.Reader.Read();
                ScanCardInfoIndex = CurrentCount.Reader.GetInt32(0);
                if (Card_timer.Enabled)
                {
                    Card_timer.Stop();
                }
                Card_timer.Start();
                label_card.Text = ((DataGridView)(((TabPage)(DatabaseTabControl.TabPages[2])).Controls[0])).Rows[ScanCardInfoIndex-1].Cells[1].Value.ToString();
            }
        }
    }
}
