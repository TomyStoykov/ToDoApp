using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using Welcome.Others;

namespace Welcome.ViewModel
{
    public class UserViewModel
    {
        private User _user;
        public UserViewModel(User user)
        {
            _user = user;
        }
        public string Name
        {
            get { return _user.Names; }
            set { _user.Names = value; }
        }
        public string Email
        {
            get { return _user.Email; }
            set { _user.Email = value; }
        }
        public string FacultyNumber
        {
            get { return _user.FacultyNumber; }
            set { _user.FacultyNumber = value; }
        }
        public UserRolesEnum Role
        {
            get { return _user.Role; }
            set { _user.Role = value; }
        }
    }
}
