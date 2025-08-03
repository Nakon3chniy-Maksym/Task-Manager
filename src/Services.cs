using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Task_Manager
{
    public class Services
    {
        private List<TaskItem> _tasks;

        public List<TaskItem> Tasks { get; set; }

        public void AddTask()
        {
            Console.Clear();
            Console.Write(">>> Enter the description for this task: ");
            string description = Console.ReadLine()!;

            TaskPriority priority;
            while (true)
            {
                Console.Write(">>> Set the priority for the task(Low, Medium, High): ");
                string priorityInput = Console.ReadLine()!.ToLower();

                if (Enum.TryParse<TaskPriority>(priorityInput, true, out priority))
                {
                    break;
                }
            }

            Tasks.Add(new TaskItem
            {
                Id = Tasks.Count > 0 ? Tasks.Max(t => t.Id) + 1 : 1,
                Date = DateTime.Now,
                Description = description!,
                Priority = priority
            });

        }

        public void RemoveTask()
        {
            Console.Clear();
            int index;
            while (true)
            {
                Console.Write(">>> Enter the index of the task you want to delete: ");
                index = Convert.ToInt32(Console.ReadLine()) - 1;

                if (index < 0 || index > Tasks.Count)
                {
                    Console.WriteLine("There's no task with such index!");
                }
                else
                {
                    break;
                }
            }
            Tasks.RemoveAt(index);
        }

        public void ShowTasks()
        {
            Console.Clear();
            for (int i = 0; i < Tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Tasks[i].Description}"
                                + $"\n\tDate: {Tasks[i].Date:dd.MM.yyyy} {Tasks[i].Date:HH.mm.ss}"
                                + $"\n\tPriority: {Tasks[i].Priority}"
                                + $"\n\tCompleted: {Tasks[i].IsCompleted}");
            }
            Console.Read();
        }
    }
}