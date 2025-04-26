using Microsoft.Maui.Controls;
using ToDoApplication.Models;
using ToDoApplication.ViewModels;

namespace ToDoApplication.Views
{
    public partial class MainPage : ContentPage
    {
        public TodoViewModel ViewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            ViewModel = new TodoViewModel();
            BindingContext = ViewModel;
        }

        private async void OnViewCompletedClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CompletedTodosPage());
        }

        private async void OnTaskSelected(object sender, ItemTappedEventArgs e)
        {
            var selectedTask = e.Item as TodoItem;
            if (selectedTask != null)
            {
                await Navigation.PushAsync(new TodoDetailPage(selectedTask));
            }

            ((ListView)sender).SelectedItem = null;
        }
    }
}
