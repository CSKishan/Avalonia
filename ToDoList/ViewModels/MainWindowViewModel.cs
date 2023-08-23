using ToDoList.Services;

namespace ToDoList.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _contentViewModel;
        public MainWindowViewModel() {
            var service = new ToDoListService();
            ToDoList = new ToDoListViewModel(service.GetItems());
            _contentViewModel = ToDoList;
        }    

        public ToDoListViewModel ToDoList { get; }

        public ViewModelBase ContentViewModel { get { return _contentViewModel; } } 
    }
}