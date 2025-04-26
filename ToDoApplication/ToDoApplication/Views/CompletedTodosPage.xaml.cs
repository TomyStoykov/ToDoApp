using Microsoft.Maui.Controls;
using ToDoApplication.ViewModels;

namespace ToDoApplication.Views
{
    public partial class CompletedTodosPage : ContentPage
    {
        public CompletedTodosPage()
        {
            InitializeComponent();
            BindingContext = new CompletedTodoViewModel();
        }
    }
}
