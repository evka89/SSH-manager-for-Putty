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

namespace Pro_SSH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Shaher Oqaili\nLanguage: C# .NET", "Info");
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press \"Main\" and select \"New server\" to add server\nPress \"Main\" and select \"Edit server\" to edit server\nPress \"Main\" and select \"Remove server\" to remove server\n", "Instruction");
        }

        private void newServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void removeServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUser.Text) || String.IsNullOrWhiteSpace(txtAddress.Text) || String.IsNullOrWhiteSpace(txtPasswd.Text))
            {
                MessageBox.Show("Please fill all fields", "Empty fiends and args.");
                return;
            }
            else
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = ".\\putty.exe";
                process.StartInfo.Arguments = txtUser.Text + "@" + txtAddress.Text + " -pw " + txtPasswd.Text;
                process.Start();
            }

        }
    }
}
