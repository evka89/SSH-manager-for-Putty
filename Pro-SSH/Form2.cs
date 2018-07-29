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
using Newtonsoft.Json;

namespace Pro_SSH
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnNewCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewSave_Click(object sender, EventArgs e)
        {
            CheckEmptyFields();
            Servers AddNewServer = new Servers();
            AddNewServer.Name = txtNewUID.Text;
            AddNewServer.Address = txtNewAddress.Text;
            AddNewServer.UserName = txtNewUserName.Text;
            AddNewServer.Password = txtNewPasswd.Text;

            if (File.Exists(".\\" + AddNewServer.Name + ".json"))
            {
                AddNewServer = null;
                MessageBox.Show("This server already created. Add any other Name or UID!", "Server exist!");
                return;
            }

            List<Servers> ServerParamsList = new List<Servers>();
            ServerParamsList.Add(AddNewServer);

            string OutFile = JsonConvert.SerializeObject(ServerParamsList, Formatting.Indented);
            File.WriteAllText(".\\" + AddNewServer.Name + ".json", OutFile);
            File.AppendAllText("ServersList.txt", AddNewServer.Name + Environment.NewLine);
            Close();
        }

        void CheckEmptyFields()
        {
            if (String.IsNullOrWhiteSpace(txtNewUID.Text) || String.IsNullOrWhiteSpace(txtNewAddress.Text) || String.IsNullOrWhiteSpace(txtNewUserName.Text) || String.IsNullOrWhiteSpace(txtNewPasswd.Text))
            {
                MessageBox.Show("Apply all fields!", "Empty fields!");
                return;
            }
        }
    }
}
