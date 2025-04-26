using Microsoft.Maui.Controls;
using ToDoApplication.Models;

namespace ToDoApplication.Views
{
    public partial class TodoDetailPage : ContentPage
    {
        public TodoDetailPage(TodoItem todoItem)
        {
            InitializeComponent();
            BindingContext = todoItem;
        }
    }
}
