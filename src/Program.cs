namespace Task_Manager;

class Program
{
    static void Main(string[] args)
    {
        bool isWorking = true;
        Services service = new Services();
        RepositoryManager repositoryManager = new RepositoryManager();
        service.Tasks = repositoryManager.LoadTasks();
        Console.WriteLine("Welcome to your personal Task Manager! ");
        Console.Read();
        while (isWorking)
        {
            Console.Clear();
            Console.WriteLine("Please choose the operation you want:"
            + "\n\t1 - Reveal your tasks"
            + "\n\t2 - Create new task"
            + "\n\t3 - Delete a task"
            + "\n\t4 - Quit and Save");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    service.ShowTasks();
                    break;
                case "2":
                    service.AddTask();
                    break;
                case "3":
                    service.RemoveTask();
                    break;
                case "4":
                    isWorking = false;
                    repositoryManager.SaveTasks(service.Tasks);
                    break;
                default:
                    Console.WriteLine("Wrong input!");
                    break;
            }
        }
        Console.Read();
    }
}
