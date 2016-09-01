using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKey
{
    public class GlobalMessages
    {
        public const string InvalidUsernameLenght = "username must be between {0} and {1} characters";
        public const string InvalidUsername = "invalid username";
        public const string AlreadyTaken = "username already taken";
        public const string PasswordsMismatch = "passwords not match";
        public const string InvalidPasswordLenght = "password must be atleast {0} characters";
        public const string InvalidPasswordFormat = "password must contain atleats one digit";
        public const string HostNameEmpty = "host name can not be empty";
        public const string HostNameAlreadyExist = "host name already exist";

        public const string NonExistingUser = "non existing username";
        public const string IncorectPassword = "incorect password";

        public const string SuccessRegistrationMessage = "Registration was successfull, now that is your one for all password. Don't forget it!";

        public const string AboutToDeleteItem = "You are about to delete your info for {0}.{1}Do you wont to continue?";
        public const string WarnningLabel = "Warnning";
        public const string AboutToShowPassword = "Your password now will be visible.{0}Do you want to continue?";

        public const string MissingBackupFile = "Missing backup file. Make sure that the backup file is in program directory.";
        public const string BackupCreated = "Backup created successfully!";
        public const string BackupRestored = "Backup restored successfully!";

        public const string BackupFileName = "backup.dat";

        public const string BackupConfirm = "This action will create backup copy of all users data into program directory so you can easily transfer it to other computers that run Windows OS.";
        public const string RestoreConfirm = "Do you want to restore your back up to this PC?";
        public const string RestoreBackup = "Restore backup";
        public const string Backup = "Backup";

        public const string Error = "Error";
        public const string Success = "Success";

        public const string PasswordChanged = "Password changed successfully!";
    }
}
