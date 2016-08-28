using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKey.Data
{
    public class DataParser
    {
        public Dictionary<string, string[]> Parse(string userData)
        {
            Dictionary<string, string[]> data = new Dictionary<string, string[]>();

            var splitedByHost = userData.Split(new[] { Constants.HostsSplitChar }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var info in splitedByHost)
            {
                string[] splitedInfo = info.Split(Constants.InfoSplitChar);
                string host = splitedInfo[0];
                string[] userInfo = new string[3];

                for (int i = 1; i < splitedInfo.Length; i++)
                {
                    userInfo[i - 1] = splitedInfo[i];
                }

                data.Add(host, userInfo);
            }

            return data;
        }
    }
}
