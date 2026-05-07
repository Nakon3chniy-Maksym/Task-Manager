using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Task_Manager_GUI.src.Commands;
using Task_Manager_GUI.src.Enums;
using Task_Manager_GUI.Stores;

namespace Task_Manager_GUI.src.Viewmodels
{
    public class AddTaskViewModel : ViewModelBase
    {
        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        private string _description;
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }

        private DegOfUrgency? _urgency;
        public DegOfUrgency? Urgency
        {
            get => _urgency;
            set
            {
                _urgency = value;
                OnPropertyChanged();
            }
        }

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public TasksCollectionViewModel tasksCollection;

        public AddTaskViewModel(NavigationStore navigationStore, Func<ListingTasksViewModel> createListingTasksViewModel, TasksCollectionViewModel tasksCollection)
        {
            SubmitCommand = new SubmitCommand(this, navigationStore, createListingTasksViewModel);
            CancelCommand = new NavigationCommand(navigationStore, createListingTasksViewModel);
            this.tasksCollection = tasksCollection;
        }
    }
}
