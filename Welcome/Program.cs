using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;

namespace Welcome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Names = "Pesho Tudjarov";
            user.Password = "123456";
            user.Role = Others.UserRolesEnum.ADMIN;
            user.Email = "pesho@gmail.com";
            user.FacultyNumber = "121212111";


            UserViewModel viewModel = new UserViewModel(user);
            viewModel.Name = user.Names;
            viewModel.Role = user.Role;
            UserView userView = new UserView(viewModel, user);
            userView.Display(UserView.VisualizationType.Standard);
            Console.WriteLine();
            userView.Display(UserView.VisualizationType.WithOutRole);

            Console.ReadKey();
        }
    }
}
