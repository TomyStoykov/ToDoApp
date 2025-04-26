using System.Collections.ObjectModel;
using System.Linq;
using ToDoApplication.Models;

namespace ToDoApplication.ViewModels
{
    public class CompletedTodoViewModel : TodoViewModel
    {
        public CompletedTodoViewModel() : base()
        {
            // Filter only completed tasks.
            var completed = TodoItems.Where(t => t.IsCompleted).ToList();
            TodoItems = new ObservableCollection<TodoItem>(completed);
        }
    }
}
