using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassKey.UserInfo
{
    public class LoggedUser
    {
        public LoggedUser(string username, byte[] key, Dictionary<string, string[]> userData)
        {
            this.Username = username;
            this.Key = key;
            this.UserData = userData;
        }

        public string Username { get; private set; }

        public byte[] Key { get; set; }

        public BindingSource Data { get; set; }

        public Dictionary<string, string[]> UserData { get; set; }

        public void AddData(string host, string[] info)
        {
            this.UserData.Add(host, info);
        }

        public void RemoveData(string host)
        {
            this.UserData.Remove(host);
        }

        public string[] GetHosts()
        {
            var hosts = this.UserData.Keys.ToArray();
            return hosts;
        }

        public string[] GetRegInfoByHost(string hostName)
        {
            var regInfo = this.UserData[hostName];
            return regInfo;
        }
    }
}