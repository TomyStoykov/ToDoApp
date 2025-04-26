using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ToDoApplication.Models;

namespace ToDoApplication.ViewModels
{

    public class TodoViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<TodoItem> TodoItems { get; set; }

        public TodoViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>
            {
                new TodoItem { Title = "Learn .NET MAUI", IsCompleted = false, Description = "Learn the basics of .NET MAUI and how to create cross-platform applications." },
                new TodoItem { Title = "Create Todo Application", IsCompleted = true, Description = "Build a simple Todo application using .NET MAUI." },
                new TodoItem { Title = "Review MVVM Template", IsCompleted = false, Description = "Understand how MVVM pattern works in .NET MAUI and how to implement it in the project." }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
