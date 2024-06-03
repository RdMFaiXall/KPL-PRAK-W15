using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul15.JSONConfiguration;

namespace Modul15.LoginRegist
{
    public class GetData
    {
        public string username { get; set; }
        public string password { get; set; }
    }

    public class Sign
    {
        
        // List<string> data = new List<string>();

        public void Registration(string username, string password)
        {
            if (username.Length <= 8 && username.Length >= 20)
            {
                Console.WriteLine("Username tidak boleh lebih kecil dari 8 karakter dan tidak boleh lebih besar dari 8 karakter");
            } else
            {
               JSONConfig getNewAccount = new JSONConfig();
                getNewAccount.NewAccount(username, password);
            }
        }

        public bool Login(string username, string password)
        {
            if (username.Length <= 8 && username.Length >= 20) 
            {
               return false;
            } else if (password.Length <= 8 && password.Length >= 20)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
