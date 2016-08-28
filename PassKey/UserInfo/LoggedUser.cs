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
        public LoggedUser(string username, byte[] key, BindingSource data)
        {
            this.Username = username;
            this.Key = key;
            this.Data = data;
        }

        public string Username { get; private set; }

        public byte[] Key { get; set; }

        public BindingSource Data { get; set; }        

        public void AddData(UserDataInfo dataInfo)
        {
            this.Data.Add(dataInfo);
        }

        public void RemoveData(int index)
        {
            this.Data.RemoveAt(index);
        }

        //public string[] GetHosts()
        //{
        //    var hosts = this.UserData.Keys.ToArray();
        //    return hosts;
        //}

        //public string[] GetRegInfoByHost(string hostName)
        //{
        //    var regInfo = this.UserData[hostName];
        //    return regInfo;
        //}
    }
}