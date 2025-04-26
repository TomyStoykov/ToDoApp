using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using WelcomeExtended.Data;

namespace WelcomeExtended.Helpers
{
    internal static class UserHelper
    {
        public static String ToString(this User user)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {user.Names}");
            sb.AppendLine($"Email: {user.Email}");
            sb.AppendLine($"Faculty Number: {user.FacultyNumber}");
            sb.AppendLine($"Role: {user.Role.ToString()}");
            sb.AppendLine($"ID: {user.Id}");
            sb.AppendLine($"Expires: {user.Expires.ToString("yyyy-MM-dd HH:mm:ss")}");

            return sb.ToString();
        }

        public static void ValidateCredentials(string name, string password,UserData UserData)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The name cannot be empty.");

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("The password cannot be empty.");

            UserData.ValidateUser(name, password);
        }
        public static User GetUser(string name, string password,UserData UserData)
        {
            return UserData.GetUser(name, password);
        }
    }

}
