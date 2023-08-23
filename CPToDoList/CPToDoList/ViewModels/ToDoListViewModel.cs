using CPToDoList.DataModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPToDoList.ViewModels
{
    public class ToDoListViewModel : ViewModelBase
    {
        public ToDoListViewModel(IEnumerable<ToDoItem> items)
        {
            ListItems = new ObservableCollection<ToDoItem>(items);
        }
        public ObservableCollection<ToDoItem> ListItems { get; }
    }
}
