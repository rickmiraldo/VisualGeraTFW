using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualGeraTFW
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            var currentAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            string versionNumber = currentAssembly.GetName().Version.ToString();
            labelVersion.Text = "v" + versionNumber;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.baseaerofoto.com.br");
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
