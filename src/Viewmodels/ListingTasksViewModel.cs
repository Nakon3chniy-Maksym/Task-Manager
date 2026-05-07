using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Task_Manager_GUI.src.Commands;
using Task_Manager_GUI.src.Models;
using Task_Manager_GUI.Stores;

namespace Task_Manager_GUI.src.Viewmodels
{
    public class ListingTasksViewModel : ViewModelBase
    {
        private readonly ObservableCollection<Task> _tasksCollection;

        public ICommand NavigationCommand { get; }

        public ListingTasksViewModel(NavigationStore navigationStore, Func<AddTaskViewModel> createAddTaskViewModel, TasksCollectionViewModel tasksCollectionViewModel)
        {
            NavigationCommand = new NavigationCommand(navigationStore, createAddTaskViewModel);
            _tasksCollection = tasksCollectionViewModel.Tasks;
        }
    }
}
