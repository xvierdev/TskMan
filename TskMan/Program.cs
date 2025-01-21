using System;
using System.Collections.Generic;
using System.Linq;
using TskMan.Entities;
using TskMan.Entities.Enums;
using TskMan.Entities.Exceptions;
namespace TskMan
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    throw new DomainException("Usage:\n"
                    + "\ntskman 1 title \"content of task\"\tCreate a new task"
                    + "\ntskman 2 IdMessage\t\t\tRemove task from list"
                    + "\ntskman 3\t\t\t\tShow all task\n");
                }
                if (args[0] == "1")
                {
                    string title = args[1];
                    string content = string.Join(" ", args.Skip(2));
                    ManTask manTask = new(title, content);
                    Console.WriteLine(manTask.ToString());
                }
                else if(args[0] == "2")
                {
                    Console.WriteLine("Not implemented");
                }
                else if(args[0] == "3")
                {
                    Console.WriteLine("Not implemented");
                }
            }
            catch(DomainException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}