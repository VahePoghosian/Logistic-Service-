using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogysticSystemService.UI.Admin
{
    public class AdminUser
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public AdminUser(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
