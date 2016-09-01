using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKey.UserInfo
{
    public class UserDataInfo : IComparable<UserDataInfo>
    {
        public UserDataInfo(string hostName, string email, string username, string password)
        {
            this.HostName = hostName;
            this.Email = email;
            this.Username = username;
            this.Password = password;
        }

        public string HostName { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int CompareTo(UserDataInfo other)
        {
            return this.HostName.CompareTo(other.HostName);
        }
    }
}
