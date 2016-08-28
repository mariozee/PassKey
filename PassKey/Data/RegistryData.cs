using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace PassKey.Data
{
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
            registry
                .OpenSubKey(Constants.PassKeySubKeyName, true)
                .OpenSubKey(Constants.UsersLoginInfoSubKey, true)
                .SetValue(username, password);
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

        public static List<string> PrepareBackup()
        {
            var backup = new List<string>();

            string[] subKeyNames = registry.OpenSubKey(Constants.PassKeySubKeyName).GetSubKeyNames();
            registry.Close();

            foreach (var subKeyName in subKeyNames)
            {
                string[] valuesNames = registry.OpenSubKey(Constants.PassKeySubKeyName).OpenSubKey(subKeyName).GetValueNames();
                registry.Close();

                foreach (var valueName in valuesNames)
                {
                    string data = registry.OpenSubKey(Constants.PassKeySubKeyName).OpenSubKey(subKeyName).GetValue(valueName).ToString();
                    registry.Close();

                    backup.Add(valueName);
                    backup.Add(data);
                }
            }

            return backup;
        }

        public static void RestoreBackup(string subKeyName, string username, string data)
        {
            registry.OpenSubKey(Constants.PassKeySubKeyName, true).OpenSubKey(subKeyName, true).SetValue(username, data);
            registry.Close();
        }
    }
}
