
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO.Pipes;
using System.IO;
using Microsoft.Win32.SafeHandles;

namespace bus0917_CS
{

    public partial class loading_form : Form
    {
        [DllImport("DLIBTRAINERDLL.dll", EntryPoint = "Train")]
        private static extern int Train();

        [DllImport("DLIBTRAINERDLL.dll", EntryPoint = "LoadImageFromDir")]
        private static extern int LoadImageFromDir();

        [DllImport("DLIBTRAINERDLL.dll", EntryPoint = "CalcFaceDescriptor")]
        private static extern int CalcFaceDescriptor(int x);

        [DllImport("DLIBTRAINERDLL.dll", EntryPoint = "SaveLabelsAndScripts")]
        private static extern int SaveLabelsAndScripts();

        [DllImport("DLIBTRAINERDLL.dll", EntryPoint = "GetAllImgSize")]
        private static extern int GetAllImgSize();

        public bool successFlag { get; set; }

        public loading_form()
        {
            this.successFlag = false;
            
            InitializeComponent();

            // To report progress from the background worker we need to set this property
            backgroundWorker1.WorkerReportsProgress = true;
            // This event will be raised on the worker thread when the worker starts
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            // This event will be raised when we call ReportProgress
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            //this.Text = "Loading...";
        }

        //object sender, EventArgs e
        public void Form_Shown()
        {
            // Start the background worker
            backgroundWorker1.RunWorkerAsync();
            
        }
        // On worker thread so do our thing!
        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int temp = 0;
           
            //StatusTextBox.AppendText("Loading Images..." + Environment.NewLine);
            temp = LoadImageFromDir();
            /*
            if (temp == 0){
                StatusTextBox.AppendText("Images Loading Completed" + Environment.NewLine);
            }else{
                StatusTextBox.AppendText("Images Loading Failed" + Environment.NewLine);
                Close();
            }*/
            
            // Your background task goes here
            for (temp = 0; temp < GetAllImgSize(); temp++)
            {
                int x = CalcFaceDescriptor(temp);
                // Report progress to 'UI' thread
                backgroundWorker1.ReportProgress(x);

                // Simulate long task
                System.Threading.Thread.Sleep(100);
            }
            
            if (temp == GetAllImgSize())
            {
                backgroundWorker1.ReportProgress(100);
                MessageBox.Show("Training success!", "Success");
                //StatusTextBox.AppendText("Training Success" + Environment.NewLine);
                SaveLabelsAndScripts();
                this.successFlag = true;
            }
            else{
                MessageBox.Show("Training Failed!", "Failure");
                //StatusTextBox.AppendText("Training Failed" + Environment.NewLine);
            }
        }
        // Back on the 'UI' thread so we can update the progress bar
        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // The progress percentage is a property of e
            progressBar1.Value = e.ProgressPercentage;
            this.Text = "Loading... " + e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender,RunWorkerCompletedEventArgs e)
        {
            //this.successFlag = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
