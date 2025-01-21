using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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
            int taskCount = 0;
            Console.WriteLine("Welcome TskMan application..");
            List<ManTask> manTasks = [];
            bool menu = true;
            while (menu)
            {
                MenuOptions options = MainMenu.Show();
                switch (options)
                {
                    case MenuOptions.NewTask:
<<<<<<< HEAD
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
=======
                        string title, content;
                        Console.Write("Task title: ");
                        title = Console.ReadLine();
                        Console.WriteLine("Task content: ");
                        content = Console.ReadLine();
                        ManTask task = new(taskCount, title, content, DateTime.Now);
                        manTasks.Add(task);
                        taskCount++;
>>>>>>> ca9b8b505946e048edf6d4b555579ebb5de1214e
                        break;
                    case MenuOptions.Details:
                        int taskNum;
                        Console.Write("Enter task id: ");
                        taskNum = int.Parse(Console.ReadLine());
                        ManTask fTask = manTasks.Find(task => task.Id == taskNum);
                        if (fTask != null)
                        {
                            Console.WriteLine(fTask.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Task not foud.");
                        }
                        break;
                    case MenuOptions.ShowTask:
                        ShowTaskList(manTasks);
                        break;
                    case MenuOptions.DeleteTask:
                        int taskId = 0;
                        Console.Write("Id of task to remove: ");
                        taskId = int.Parse(Console.ReadLine());
                        bool result  = manTasks.Remove(manTasks.Find(task => task.Id == taskId));
                        if (result)
                        {
                            Console.WriteLine($"Task {taskId} has been removed!");
                        }
                        else
                        {
                            Console.WriteLine("Failed to remove task, not foud.");
                        }
                        break;
                    case MenuOptions.Exit:
                        Console.WriteLine("Bye!");
                        menu = false;
                        break;
                }
            }
        }

        static void ShowTaskList(List<ManTask> manTasks)
        {
            foreach (ManTask task in manTasks)
            {
                Console.WriteLine(task.ToString());
            }
        }
    }
}