﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList_2.DataModel;

namespace ToDoList_2.Services
{
    public class ToDoListService
    {
        public IEnumerable<ToDoItem> GetItems() => new[]
        {
            new ToDoItem {Description = "Walk the dog"},
            new ToDoItem {Description = "Buy some milk"},
            new ToDoItem {Description = "Learn Avalonia", IsChecked = true},
        };
    }
}
