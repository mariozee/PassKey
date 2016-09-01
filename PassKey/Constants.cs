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

        //vector initializer value 16
        public const string IV = "vl#*eA^S!_vzTAm^";

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

        //backup encrypt/decrypt 32  
        public static string BackupString = "V0kG(0Od18-wMzcl55oltL9Uz+CNMU5t";
        public static byte[] backUpKey = ASCIIEncoding.ASCII.GetBytes(BackupString);

        public const string BackupMark = "8Zv*pIwm(GEriDF>Ac-(w?GsPZ6i^tK>";

        //info
        public const string MyEmail = "mario.zisov@gmail.com";
        public const string GitHubPage = "https://github.com/zisov4eto/PassKey";
    }
}
