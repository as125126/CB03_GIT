using MjpegProcessor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bus0917_CS
{
    public partial class Form1 : Form
    {
        [DllImport("DLIBTRAINERDLL.dll", EntryPoint = "Check_user")]
        private static extern IntPtr Check_user();

        [DllImport("TAKEPICTUREDLL.dll", EntryPoint = "TakePicture")]
        private static extern bool TakePicture(string str);

        [DllImport("TAKEPICTUREDLL.dll", EntryPoint = "Convert_PGM_to_JPG")]
        private static extern bool Convert_PGM_to_JPG(string str);

        private List<string> temp_list;
        private ImageList imageList;
        private List<string> paths;
        private int to_delete = -1;
        private string newest_user;

        MjpegDecoder _mjpeg;
        private string pi_ip;
        public Form1()
        {
            InitializeComponent();

            _mjpeg = new MjpegDecoder();
            _mjpeg.FrameReady += mjpeg_FrameReady;

            input_ip_box iib = new input_ip_box();

            if( DialogResult.OK == iib.ShowDialog())
            {
                pi_ip = iib.get_ip();
                label1.Text = pi_ip;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void add_face_name_textbox_TextChanged(object sender, EventArgs e)
        {
            if(!add_face_name_textbox.Text.Equals(""))
            { add_face_start_button.Enabled = true; }
            else
            { add_face_start_button.Enabled = false; }
        }

        private Image GetImage(string fileName)
        {
            byte[] bytes = File.ReadAllBytes(fileName);
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void imageListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imageListView.SelectedItems.Count > 0)
            {
                to_delete = imageListView.Items.IndexOf(imageListView.SelectedItems[0]);

                imageListView.Items.Remove(imageListView.Items[to_delete]);
                imageList.Images.RemoveAt(to_delete);
                try
                {
                    File.Delete(paths[to_delete]);
                }
                catch (IOException ioe)
                {
                    label1.Text = ioe.Message;
                }

                int r = Int32.Parse(Path.GetFileNameWithoutExtension(paths[to_delete]));

                if (File.Exists("att_faces/" + newest_user + "/" + r.ToString() + ".PGM"))
                { File.Delete("att_faces/" + newest_user + "/" + r.ToString() + ".PGM"); }

                if (File.Exists("att_faces/" + newest_user + "/" + r.ToString() + ".pgm"))
                { File.Delete("att_faces/" + newest_user + "/" + r.ToString() + ".pgm"); }

                label1.Text = "att_faces/" + newest_user + "/" + r.ToString() + ".pgm";

                paths.RemoveAt(to_delete);

            }
        }

        private void show_reault_picture( string username )
        {
            imageList = new ImageList();
            this.imageListView.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo("temp_data_" +username);
            paths = new List<string>();


            foreach (FileInfo file in dir.GetFiles())
            {
                paths.Add(file.FullName);
                try
                {
                    imageList.Images.Add(GetImage(file.FullName));
                }
                catch (Exception e)
                { label1.Text += e.ToString() + "\n"; }
            }
            imageList.ImageSize = new Size(92, 112);

            this.imageListView.View = View.LargeIcon;

            for (int counter = 0; counter < imageList.Images.Count; counter++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = counter;
                this.imageListView.Items.Add(item);
            }
            this.imageListView.LargeImageList = imageList;


        }

        private void add_face_start_button_Click(object sender, EventArgs e)
        {
            newest_user = add_face_name_textbox.Text;
            bool res = TakePicture(add_face_name_textbox.Text);
            bool con = Convert_PGM_to_JPG(add_face_name_textbox.Text);
            show_reault_picture(add_face_name_textbox.Text);

            add_face_name_textbox.Text = "";

            if (res)
            { MessageBox.Show("take pucture success !", "Success"); }
            else
            { MessageBox.Show("take picture failure OTL ~", "Failure"); }

            finish_add_picture_button.Enabled = true;
            finish_add_picture_button.Visible = true;

        }

        private void finish_add_picture_button_Click(object sender, EventArgs e)
        {
            imageListView.Items.Clear();
            imageList.Images.Clear();
            paths.Clear();

            if (Directory.Exists("temp_data_" + newest_user))
            { Directory.Delete("temp_data_" + newest_user , true ); }

            finish_add_picture_button.Enabled = false;
            finish_add_picture_button.Visible = false;
        }

        private void add_face_cancel_button_Click(object sender, EventArgs e)
        {
            add_face_name_textbox.Text = "";
        }




        private void clear_folder(string folder_name)
        {
            DirectoryInfo dir = new DirectoryInfo(folder_name);

            foreach (FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }
        }

        private void train_button_Click(object sender, EventArgs e)
        {
            loading_form lf = new loading_form();
            lf.Show();
            lf.Form_Shown();

            List<Control> delete_list = new List<Control>();

             foreach( Control con in main_tab_control.TabPages[2].Controls )
            {
                if( con is Panel && con.Name.Contains("panel_new_"))
                {
                    delete_list.Add(con);
                }
            }

             for( int c = delete_list.Count - 1; c > -1; --c )
            {
                main_tab_control.TabPages[2].Controls.Remove(delete_list[c]);
            }


            clear_folder("temp_data");
            train_title_label.Text = "Trained";
            train_button.Enabled = false;
        }

        private void add_new_panel_face_by_list(List<string> name)
        {
            int untrained = 0;
            
            for ( int c = 0; c < name.Count -1 ; ++c )
            {
                if( !name[c].Contains("empty") )
                {
                    untrained++;
                    Label new_label = new Label();
                    new_label.Name = "label_new_" + name;
                    new_label.Location = new Point(4, 120);
                    new_label.AutoSize = false;
                    new_label.Width = 92;
                    new_label.Height = 20;
                    new_label.TextAlign = ContentAlignment.MiddleCenter;
                    new_label.Text = name[c];
                    

                    PictureBox new_picture_box = new PictureBox();
                    new_picture_box.Name = "picturebox_new_" + name[c];
                    new_picture_box.Location = new Point(4, 4);
                    new_picture_box.Width = 92;
                    new_picture_box.Height = 112;
                    new_picture_box.SizeMode = PictureBoxSizeMode.StretchImage;
                    new_picture_box.ImageLocation = "temp_data\\" + name[c] + ".jpg";

                    Panel new_panel = new Panel();
                    new_panel.Name = "panel_new_" + name[c];
                    new_panel.Location = new Point(100 + 130 * c, 50);
                    new_panel.Width = 100;
                    new_panel.Height = 145;

                    new_panel.Controls.Add(new_picture_box);
                    new_panel.Controls.Add(new_label);

                    main_tab_control.TabPages[2].Controls.Add(new_panel);
                }
                else
                {
                    MessageBox.Show("user: " + name[c].Replace("empty ", "") + " folder is empty", "error");
                }


            }
            
            if( untrained > 0 )
            {
                train_title_label.Text = untrained.ToString() +" people need to update";
                train_button.Enabled = true;
            }
            else
            {
                train_title_label.Text = "Doesn't need to update";
                train_button.Enabled = false;
            }
            if( untrained > 3 )
            { train_title_label.Text = "More than 3 new people need to update"; }

        }



        private void main_tab_control_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = main_tab_control.SelectedIndex.ToString();

            if(main_tab_control.SelectedIndex == 2)
            {
                label2.Text = "";
                String temp = Marshal.PtrToStringAnsi(Check_user());

                string[] temps = temp.Split(';');
                temp_list = new List<string>(temp.Split(';') );

                if ( temps[0].Equals("false") )
                {
                    MessageBox.Show("Never trained !", "Message");
                    train_title_label.Text = "Train your data!";
                    train_button.Enabled = true;
                }
                else
                {
                    temp_list.Remove("true");

                    label2.Text = "";
                    foreach( string s in temp_list )
                    {
                        label2.Text += s + "\n";
                    }

                    if (temp_list.Count == 0)
                    {
                        MessageBox.Show("Nothing for update !", "Nothing change");
                        train_button.Enabled = false;
                    }
                    else
                    { add_new_panel_face_by_list(temp_list); }
                }

            }

        }

        private void start_button_Click(object sender, EventArgs e)
        {
            _mjpeg.ParseStream(new Uri("http://"+ pi_ip  +":8080/?action=stream"));
            start_button.Enabled = false;
            stop_button.Enabled = true;
            frame_picturebox.Visible = true;
            stream_ip_textbox.Enabled = false;
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            _mjpeg.StopStream();
            stop_button.Enabled = false;
            start_button.Enabled = true;
            frame_picturebox.Visible = false;
            stream_ip_textbox.Enabled = true;
        }

        private void mjpeg_FrameReady(object sender, FrameReadyEventArgs e)
        {
            frame_picturebox.Image = e.Bitmap;
            //image.Source = e.BitmapImage;
        }

        
    }
}
