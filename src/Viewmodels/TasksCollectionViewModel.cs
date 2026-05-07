using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Task_Manager_GUI.src.Models;

namespace Task_Manager_GUI.src.Viewmodels
{
    public class TasksCollectionViewModel
    {
        public ObservableCollection<Task> Tasks { get; } = new ObservableCollection<Task>();
    }
}
