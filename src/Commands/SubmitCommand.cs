using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using Task_Manager_GUI.src.Models;
using Task_Manager_GUI.src.Viewmodels;
using Task_Manager_GUI.Stores;

namespace Task_Manager_GUI.src.Commands
{
    public class SubmitCommand : CommandBase
    {
        private readonly AddTaskViewModel _addTaskViewModel;
        private readonly NavigationStore _navigationStore;
        private readonly Func<ViewModelBase> _createViewModel;

        public SubmitCommand(AddTaskViewModel addTaskViewModel, NavigationStore navigationStore, Func<ViewModelBase> createViewModel)
        {
            _addTaskViewModel = addTaskViewModel;
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;

            _addTaskViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(AddTaskViewModel.Title) ||
                e.PropertyName == nameof(AddTaskViewModel.Description) ||
                e.PropertyName == nameof(AddTaskViewModel.Urgency))
            {
                OnCanExecuteChanged();
            }
        }

        public override bool CanExecute(object parameter)
        {
            return !String.IsNullOrEmpty(_addTaskViewModel.Title) &&
                !String.IsNullOrEmpty(_addTaskViewModel.Description) &&
                _addTaskViewModel.Urgency != null;
        }

        public override void Execute(object parameter)
        {
            Task task = new Task(_addTaskViewModel.Title, _addTaskViewModel.Description, _addTaskViewModel.Urgency);
            try
            {
                _addTaskViewModel.tasksCollection.Tasks.Add(task);
                MessageBox.Show("Task created!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                _navigationStore.CurrentViewModel = _createViewModel();
            }
            catch (Exception)
            {

            }
        }
    }
}
