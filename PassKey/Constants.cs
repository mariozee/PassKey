namespace PassKey
{
    using System.Text;

    public static class Constants
    {
        //sub keys names
        public const string UsersDataSubKeyPath = "passkey\\usersdata";
        public const string UsersLoginSubKeyPath = "passkey\\logindata";

        //vector initializer value 16byte
        public const string IV = "vl#*eA^S!_vzTAm^";

        //registration validation
        public const int MinUsernameLenght = 4;
        public const int MaxUsernameLenght = 15;
        public const int MinPasswordLenght = 8;
        public const int MaxPasswordLenght = 32;
        public const string UsernameValidationPattern = "^[a-zA-Z0-9]+$";
        public const string PasswordValidationPattern = "[0-9]+";

        //DataParser
        public const char HostsSplitChar = '&';
        public const char InfoSplitChar = '/';

        //backup encrypt/decrypt 32byte  
        public const string BackupString = "V0kG(0Od18-wMzcl55oltL9Uz+CNMU5t";
        public static byte[] backUpKey = ASCIIEncoding.ASCII.GetBytes(BackupString);

        public const string BackupMark = "8Zv*pIwm(GEriDF>Ac-(w?GsPZ6i^tK>";
        public const string ExpectedMark = "f7wDccjXkOotrMW55jGqJWP5tOxKvxamhJXLaxLH+g0TI/9of635s7f/YmedwzUI";

        //info
        public const string MyEmail = "mario.zisov@gmail.com";
        public const string GitHubPage = "https://github.com/zisov4eto/PassKey";

        //backup file name
        public const string BackupFileName = "{0}_backup.dat";

        //restore panel
        public const string FolderDialogFilter = "All Files(*.dat) | *.dat";
    }
}
