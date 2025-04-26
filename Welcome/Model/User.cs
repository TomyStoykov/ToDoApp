using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        private string _names;
        private string _password;
        private UserRolesEnum _role;
        private string _email;
        private string _facultyNumber;
        private int _id;
        private DateTime _expires;

        public string Names {
            get { return _names; }
            set { _names = value; }
        }

        public string Password
        {
            get { return Decrypt(_password); }
            set { _password = Encrypt(value); }
        }
        
        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        public DateTime Expires { get { return _expires; } set {  _expires = value; } }

        private string Encrypt(string input)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)(chars[i] - 2);
            }
            return new string(chars);
        }

        private string Decrypt(string input)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)(chars[i] + 2);
            }
            return new string(chars);
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string FacultyNumber
        {
            get{ return _facultyNumber;}
            set { _facultyNumber = value;}
        }

        public UserRolesEnum Role
        {
            get { return (UserRolesEnum)_role; }
            set { _role = value; }
        }
    }
}
