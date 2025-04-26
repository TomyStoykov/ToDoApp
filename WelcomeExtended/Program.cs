using Microsoft.Extensions.Logging;
using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;
using WelcomeExtended.Data;
using WelcomeExtended.Helpers;
using WelcomeExtended.Loggers;
using WelcomeExtended.Others;
namespace WelcomeExtended

{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserData userData = new UserData();
            LoggerLogin logger = new LoggerLogin("login_log.txt");
            User stundentUser = new User()
            {
                Names = "student",
                Password = "password",
                Role = UserRolesEnum.ADMIN
            };
            userData.AddUser(stundentUser);

            User student2 = new User()
            {
                Names = "Student2",
                Password = "123",
                Role = UserRolesEnum.STUDENT
            };
            userData.AddUser(student2);

            User teacher = new User()
            {
                Names = "Teacher",
                Password = "1234",
                Role = UserRolesEnum.PROFESSOR
            };
            userData.AddUser(teacher);

            User admin = new User()
            {
                Names = "Admin",
                Password = "12345",
                Role = UserRolesEnum.ADMIN
            };
            userData.AddUser(admin);

            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();

            User foundUser = userData.GetUser(username, password);
            if (foundUser != null)
            {
                Console.WriteLine(UserHelper.ToString(foundUser));
                logger.Log($"Success: User {username} logged in at {DateTime.Now}.");
            }
            else
            {
                Console.WriteLine("Потребителят не е намерен");
                logger.Log($"Failure: Login attempt failed for username {username} at {DateTime.Now}.");
            }
        }
    }
}

