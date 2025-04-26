using System;
using Welcome.Model;
using Welcome.ViewModel;

namespace Welcome.View
{
    public class UserView
    {
        private UserViewModel _viewModel;

        public UserView(UserViewModel viewModel, User user)
        {
            _viewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
            _viewModel.Name = user.Names;
            _viewModel.Role = user.Role;
            _viewModel.Email = user.Email;
            _viewModel.FacultyNumber = user.FacultyNumber;
        }

        public UserView(UserViewModel viewModel)
        {
            _viewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        public enum VisualizationType
        {
            Standard,
            WithOutRole
        }

        public void Display(VisualizationType visualization)
        {
            switch (visualization)
            {
                case VisualizationType.Standard:
                    DisplayStandard();
                    break;
                case VisualizationType.WithOutRole:
                    DisplayWithOutRole();
                    break;
                default:
                    Console.WriteLine("Invalid visualization type.");
                    break;
            }
        }
        public void DisplayStandard()
        {
            if (_viewModel == null)
            {
                Console.WriteLine("ViewModel is not initialized.");
                return;
            }

            Console.WriteLine("Welcome");
            Console.WriteLine("User: " + _viewModel.Name);
            Console.WriteLine("Role: " + _viewModel.Role);
            Console.WriteLine("Email: " + _viewModel.Email);
            Console.WriteLine("Faculty Number: " + _viewModel.FacultyNumber);
        }

        public void DisplayWithOutRole()
        {
            if (_viewModel == null)
            {
                Console.WriteLine("ViewModel is not initialized.");
                return;
            }

            Console.WriteLine("Welcome");
            Console.WriteLine("User: " + _viewModel.Name);
            Console.WriteLine("Email: " + _viewModel.Email);
            Console.WriteLine("Faculty Number: " + _viewModel.FacultyNumber);
        }

        public void DisplayError()
        {
            throw new Exception("ERROR TEXT");
        }
    }
}
