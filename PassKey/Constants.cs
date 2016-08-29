using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKey
{
    public static class Constants
    {
        //sub keys names
        public const string UsersDataSubKeyPath = "passkey\\usersdata";
        public const string UsersLoginSubKeyPath = "passkey\\logindata";

        public const string GeneralSubKey = "Software";
        public const string PassKeySubKeyName = "PassKey";
        public const string UsersLoginInfoSubKey = "LoginData";
        public const string UsersDataSubKey = "UsersData";

        //vector initializer value
        public const string IV = "k1$m4wH1T3a$n!g@";

        //registration validation
        public const int MinUsernameLenght = 4;
        public const int MaxUsernameLenght = 15;
        public const int MinPasswordLenght = 8;
        public const int MaxPasswordLenght = 32;
        public const string UsernameValidationPattern = "^[a-zA-Z0-9]+$";
        public const string PasswordValidationPattern = "[0-9]+";

        //register form
        public const string BaseUsernameExceptionKeyWord = "username";
        public const string BasePasswordExceptionKeyWord = "password";

        //DataParser
        public const char HostsSplitChar = '&';
        public const char InfoSplitChar = '/';

        //backup encrypt/decrypt
        public const string BackupString = "PassKeyMarioZisovSoftware2016CM3";
        public static byte[] backUpKey = ASCIIEncoding.ASCII.GetBytes(BackupString);
        public const string BackupMark = "PassKeyBackupValidatingMark";
    }
}
