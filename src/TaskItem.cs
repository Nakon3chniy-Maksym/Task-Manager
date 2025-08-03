using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Manager
{
    public class TaskItem
    {
        public int Id {get; set;}
        public string Title {get; set;}
        public DateTime Date {get; set;}
        public string Description {get; set;}
        public TaskPriority Priority {get; set;} = TaskPriority.Medium;
        public bool IsCompleted {get; set;} = false;

    }
}