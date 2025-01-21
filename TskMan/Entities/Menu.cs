using System;
using TskMan.Entities.Enums;
namespace TskMan.Entities
{
    static class Menu
    {
        public static MenuOptions Show()
        {
            try
            {
                // Show menu options to select action
                Console.WriteLine((int)MenuOptions.NewTask + " : Create new task");
                Console.WriteLine((int)MenuOptions.ShowTask + " : Show tasks");
                Console.WriteLine((int)MenuOptions.DeleteTask + " : Delete task.");
                Console.WriteLine((int)MenuOptions.Exit + " : Exit.");
                Console.Write("Choose your option: ");
                return Enum.Parse<MenuOptions>(Console.ReadLine());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return MenuOptions.None;
            }
        }
    }
}