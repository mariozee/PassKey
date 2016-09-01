namespace PassKey.Data
{
    using System;
    using System.Text;
    using System.Windows.Forms;
    using SecurityUtilities;
    using UserInfo;

    public static class DataTranslator
    {
        public static BindingSource Parse(string username, byte[] key)
        {
            BindingSource parsedData = new BindingSource();

            string encryptedData = RegistryData.GetUserData(username);
            string decrypedData = CryptographicUtilities.Decrypt(encryptedData, key);

            var splitedByHost = decrypedData.Split(new[] { Constants.HostsSplitChar }
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

        public static void Compose(BindingSource userData, string username, byte[] key)
        {
            StringBuilder builder = new StringBuilder();

            foreach (var info in userData)
            {
                var hostInfo = (UserDataInfo)info;
                builder.AppendFormat("{0}{4}{1}{4}{2}{4}{3}{5}",
                    hostInfo.HostName, hostInfo.Email, hostInfo.Username, 
                    hostInfo.Password, Constants.InfoSplitChar, Constants.HostsSplitChar);
            }

            string encrypedData = CryptographicUtilities.Encrypt(builder.ToString(), key);
            RegistryData.SetUserData(username, encrypedData);
        }
    }
}
