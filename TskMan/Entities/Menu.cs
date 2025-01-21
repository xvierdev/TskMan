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
                Console.WriteLine(MenuOptions.NewTask + " : Create new task");
                Console.WriteLine(MenuOptions.ShowTask + " : Show tasks");
                Console.WriteLine(MenuOptions.DeleteTask + " : Delete task.");
                Console.WriteLine(MenuOptions.Exit + " : Exit.");
                Console.Write("Choose your option: ");
                return Enum.Parse<MenuOptions>(Console.ReadLine());
            }
            catch (ArgumentException ex){
                Console.WriteLine("Error: " + ex.Message);
                return MenuOptions.None;
            }
        }
    }
}