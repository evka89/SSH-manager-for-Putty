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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            RefreshCOmboList();
        }
        List<string> ServersList = new List<string>();
        public void RefreshCOmboList()
        {
            

            StreamReader SR = new StreamReader(".\\ServersList.txt");
            string currentline;
            while ((currentline = SR.ReadLine()) != null)
            {
                ServersList.Add(currentline);
            }
            SR.Close();
            comboBox1.Items.Clear();
            for (int i = 0; i < ServersList.Count; i++)
            {
                comboBox1.Items.Add(ServersList[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckCOmboBox();

        }

        void CheckCOmboBox()
        {
            if (String.IsNullOrWhiteSpace(comboBox1.Text) || comboBox1.Text.Contains("Select server"))
            {
                MessageBox.Show("Select server from server list", "No server selected");
                return;
            }
            else
            {
                DbCOnnecting DBR = new DbCOnnecting();
                DBR.CurrentServerFromCOmbo = comboBox1.Text;
                DBR.OpenJsonFile();
                Close();
                Form1 form1 = new Form1();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(comboBox1.Text) || comboBox1.Text.Contains("Select server"))
            {
                MessageBox.Show("Select server from server list", "No server selected");
                return;
            }
            else if (!File.Exists(".\\" + comboBox1.Text + ".json"))
            {
                MessageBox.Show("File does not exist!");
                return;
            }

            
            else
            {
                List<string> AllElements = new List<string>();
                File.Delete(".\\" + comboBox1.Text + ".json");

                List<string> NewList = new List<string>();
                foreach (string item in ServersList)
                {
                    if(item == comboBox1.Text)
                    {
                        continue;
                    }
                    if (String.IsNullOrWhiteSpace(item))
                    {
                        continue;
                    }
                    else
                    {
                        NewList.Add(item);
                    }
                }

                StreamWriter SW = new StreamWriter(".\\ServersList.txt");
                for (int i = 0; i < NewList.Count; i++)
                {
                    SW.WriteLine(NewList[i]);
                }
                SW.Close();


                Close();


            }
        }
    }
}
