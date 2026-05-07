using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Manager_GUI.src.Enums;

namespace Task_Manager_GUI.src.Models
{
    public class Task
    {
        public Task(string title, string description, DegOfUrgency? urgency)
        {
            Title = title;
            Description = description;
            Urgency = urgency;
            Time = DateTime.Now;
        }

        public string Title { get; }
        public string Description { get; }
        public DegOfUrgency? Urgency { get; }
        public DateTime Time { get; }
    }
}
