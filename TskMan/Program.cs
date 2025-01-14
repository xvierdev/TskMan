using System;
using System.Collections.Generic;
using TskMan.Entities;
using TskMan.Menu;
namespace TskMan
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Welcome TskMan application..");
            List<ManTask> manTasks = [];
            Console.WriteLine(MainMenu.Show());
        }
    }
}