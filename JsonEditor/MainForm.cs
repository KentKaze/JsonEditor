using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmiLoadJsonDirectory_Click(object sender, EventArgs e)
        {
            DialogResult dr = fbdMain.ShowDialog(this);
            if(dr == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(fbdMain.SelectedPath);

                MessageBox.Show("Files found: " + files.Length.ToString(), "Message");

                
            }
        }
    }
}
