using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public BindingSource Adat { get; set; }

        public void AddData(UserDataInfo dataInfo)
        {
            this.Data.Add(dataInfo);
        }

        public void RemoveData(int index)
        {
            this.Data.RemoveAt(index);
        }

        public void InsertData(int index, UserDataInfo dataInfo)
        {
            this.Data.Insert(index, dataInfo);
        }

        public void SortData(int direction)
        {
            if (direction == 1 || direction == -1)
            {
                for (int i = this.Data.Count - 1; i > 0; i--)
                {
                    for (int j = 0; j <= i - 1; j++)
                    {
                        var first = (UserDataInfo)this.Data[j];
                        var second = (UserDataInfo)this.Data[j + 1];
                        if (first.CompareTo(second) != direction)
                        {
                            var highValue = first;

                            this.Data[j] = this.Data[j + 1];
                            this.Data[j + 1] = highValue;
                        }
                    }
                }
            }
        }
    }
}