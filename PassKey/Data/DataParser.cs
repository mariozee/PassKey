using PassKey.UserInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassKey.Data
{
    public class DataParser
    {
        public BindingSource Parse(string userData)
        {
            BindingSource parsedData = new BindingSource();

            var splitedByHost = userData.Split(new[] { Constants.HostsSplitChar }
            , StringSplitOptions.RemoveEmptyEntries);

            foreach (var info in splitedByHost)
            {
                string[] splitedInfo = info.Split(Constants.InfoSplitChar);
                UserDataInfo dataInfo = new UserDataInfo(
                    splitedInfo[0], splitedInfo[1], splitedInfo[2], splitedInfo[3]);
                parsedData.Add(dataInfo);
            }

            return parsedData;
        }
    }
}
