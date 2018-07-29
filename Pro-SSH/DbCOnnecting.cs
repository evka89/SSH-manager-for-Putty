using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_SSH
{
    class DbCOnnecting : Servers
    {
        public string CurrentServerFromCOmbo { get; set; }
        public void OpenJsonFile()
        {
            string json = File.ReadAllText(".\\" + CurrentServerFromCOmbo + ".json");
            var JsonObjList = JsonConvert.DeserializeObject<List<Servers>>(json);
            for (int i = 0; i < JsonObjList.Count; i++)
            {
                Servers Elements = new Servers();
                Elements = JsonObjList[i];

                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName =  ".\\putty.exe";
                process.StartInfo.Arguments = Elements.UserName + "@" + Elements.Address + " -pw " + Elements.Password;
                process.Start();
            }
        }
    }
}
