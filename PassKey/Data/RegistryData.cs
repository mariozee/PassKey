namespace PassKey.Data
{
    using System.Text;
    using Microsoft.Win32;
    using SecurityUtilities;

    public static class RegistryData
    {
        private static RegistryKey registry = Registry.CurrentUser;

        public static string[] GetUsernames()
        {
            string[] usernames = registry.OpenSubKey(Constants.UsersLoginSubKeyPath)
                .GetValueNames();
            registry.Close();

            return usernames;
        }

        public static string GetUserData(string username)
        {
            string userData = registry.OpenSubKey(Constants.UsersDataSubKeyPath)
                .GetValue(username).ToString();
            registry.Close();

            return userData;
        }

        public static void SetUserData(string username, string userData)
        {
            registry.OpenSubKey(Constants.UsersDataSubKeyPath, true).SetValue(username, userData);
            registry.Close();
        }

        public static void SetNewPassword(string username, string password)
        {
            registry.OpenSubKey(Constants.UsersLoginSubKeyPath, true).SetValue(username, password);
            registry.Close();
        }

        public static string GetUserPassword(string username)
        {
            string password = registry.OpenSubKey(Constants.UsersLoginSubKeyPath)
                .GetValue(username)
                .ToString();
            registry.Close();

            return password;
        }

        public static void CreateUser(string username, string password, string data)
        {
            registry.OpenSubKey(Constants.UsersLoginSubKeyPath, true).SetValue(username, password);
            registry.Close();

            registry.OpenSubKey(Constants.UsersDataSubKeyPath, true).SetValue(username, data);
            registry.Close();
        }

        public static string[] GetDataForBackup(string username)
        {
            string logInfo = registry.OpenSubKey(Constants.UsersLoginSubKeyPath).GetValue(username).ToString();
            string userData = registry.OpenSubKey(Constants.UsersDataSubKeyPath).GetValue(username).ToString();

            string[] dataForBackup = new string[4];
            dataForBackup[0] = Constants.BackupMark;
            dataForBackup[1] = username;
            dataForBackup[2] = logInfo;
            dataForBackup[3] = userData;

            byte[] key = ASCIIEncoding.ASCII.GetBytes(Constants.BackupString);

            for (int i = 0; i < dataForBackup.Length; i++)
            {
                dataForBackup[i] = CryptographicUtilities.Encrypt(dataForBackup[i], key);
            }

            return dataForBackup;
        }

        public static void SetRestoredData(string[] data)
        {
            for (int i = 1; i < data.Length; i++)
            {
                data[i] = CryptographicUtilities.Decrypt(data[i], Constants.backUpKey);
            }

            string username = data[1];
            string logInfo = data[2];
            string userData = data[3];

            registry.OpenSubKey(Constants.UsersLoginSubKeyPath, true).SetValue(username, logInfo);
            registry.Close();
            registry.OpenSubKey(Constants.UsersDataSubKeyPath, true).SetValue(username, userData);
            registry.Close();
        }

        public static void DeleteAccout(string username)
        {
            registry.OpenSubKey(Constants.UsersLoginSubKeyPath, true).DeleteValue(username);
            registry.Close();
            registry.OpenSubKey(Constants.UsersDataSubKeyPath, true).DeleteValue(username);
            registry.Close();
        }
    }
}