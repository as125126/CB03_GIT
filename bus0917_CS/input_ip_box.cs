using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bus0917_CS
{
    public partial class input_ip_box : Form
    {
        private string return_ip;
        public input_ip_box()
        {
            InitializeComponent();
            ok_button.DialogResult = DialogResult.OK;
        }

        public input_ip_box(string s)
        {
            InitializeComponent();
            ip_textbox.Text = s;
            ok_button.DialogResult = DialogResult.OK;
        }

        public string get_ip()
        {
            return return_ip;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            return_ip = ip_textbox.Text;
        }
    }
}
