using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TskMan.Entities;
using TskMan.Entities.Exceptions;
using TskMan.Menu;
using TskMan.Menu.Enums;
namespace TskMan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome TskMan application..");
            List<ManTask> manTasks = [];
            while (true)
            {
                MenuOptions options = MainMenu.Show();
                switch (options)
                {
                    case MenuOptions.NewTask:
                        try
                        {
                            Console.WriteLine("Criar nova task");
                            string title, content;
                            Console.Write("Task title: ");
                            title = Console.ReadLine();
                            Console.WriteLine("Task content: ");
                            content = Console.ReadLine();
                            ManTask task = new(title, content);
                            manTasks.Add(task);
                        }
                        catch (DomainException ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        break;
                    case MenuOptions.Details:
                        Console.WriteLine("Show details");
                        break;
                    case MenuOptions.ShowTask:
                        ShowTaskList(manTasks);
                        break;
                    case MenuOptions.DeleteTask:
                        Console.WriteLine("Delete task");
                        break;
                    case MenuOptions.Exit:
                        Console.WriteLine("Bye!");
                        break;
                }
                if (options == MenuOptions.Exit)
                    break;
            }
        }

        static void ShowTaskList(List<ManTask> manTasks)
        {
            foreach (ManTask task in manTasks)
            {
                Console.WriteLine(task.Title);
                Console.WriteLine(task.CreationDateTime.ToString("dd/MM/yyyy HH:mm:ss"));
                Console.WriteLine(task.Content);
                Console.WriteLine();
            }
        }
    }
}