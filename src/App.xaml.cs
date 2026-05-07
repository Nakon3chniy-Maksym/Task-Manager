using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Task_Manager_GUI.src.Viewmodels;
using Task_Manager_GUI.src.Views;
using Task_Manager_GUI.src.Stores;

namespace Task_Manager_GUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private NavigationStore _navigationStore;
        private TasksCollectionViewModel _tasksCollection;

        public App()
        {
            _navigationStore = new NavigationStore();
            _tasksCollection = new TasksCollectionViewModel();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = CreateListingTasksViewModel();

            MainWindow mainwin = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
                //DataContext = new AddTaskViewModel(_navigationStore, CreateListingTasksViewModel, _tasksCollection)
            };
            mainwin.Show();

            base.OnStartup(e);
        }

        private AddTaskViewModel CreateAddTaskViewModel()
        {
            return new AddTaskViewModel(_navigationStore, CreateListingTasksViewModel, _tasksCollection);
        }

        private ListingTasksViewModel CreateListingTasksViewModel()
        {
            return new ListingTasksViewModel(_navigationStore, CreateAddTaskViewModel, _tasksCollection);
        }
    }
}
