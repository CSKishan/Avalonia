﻿using CPToDoList.Services;
using ReactiveUI;
using System.Reactive.Linq;
using System;
using CPToDoList.DataModel;

namespace CPToDoList.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase _contentViewModel;
        public ToDoListViewModel ToDoList { get;}
        public MainViewModel()
        {
            var service = new ToDoListService();
            ToDoList = new ToDoListViewModel(service.GetItems());
            _contentViewModel = ToDoList;
        }

        public ViewModelBase ContentViewModel
        {
            get => _contentViewModel;
            set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
        }

        public void AddItem()
        {
            AddItemViewModel addItemViewModel = new();

            Observable.Merge(
                addItemViewModel.OkCommand,
                addItemViewModel.CancelCommand.Select(_ => (ToDoItem?)null))
                .Take(1)
                .Subscribe(newItem =>
                {
                    if (newItem != null)
                    {
                        ToDoList.ListItems.Add(newItem);
                    }
                    ContentViewModel = ToDoList;
                });

            ContentViewModel = addItemViewModel;
        }
    }
}