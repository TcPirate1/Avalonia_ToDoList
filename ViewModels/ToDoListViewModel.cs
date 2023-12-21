using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.DataModel;

namespace ToDoList.ViewModels
{
    public class ToDoListViewModel(IEnumerable<ToDoItem> items) : ViewModelBase
    {
        public ObservableCollection<ToDoItem> ListItems { get; } = new ObservableCollection<ToDoItem>(items);
    }
}
