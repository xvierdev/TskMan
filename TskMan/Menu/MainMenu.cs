using System;
using TskMan.Menu.Enums;
namespace TskMan.Menu
{
    static class MainMenu
    {
        public static MenuOptions Show()
        {
            try
            {
                Console.WriteLine(MenuOptions.NewTask + " : Create new task.");
                Console.WriteLine(MenuOptions.ShowTask + " : Show tasks.");
                Console.WriteLine(MenuOptions.Details + " : View details.");
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