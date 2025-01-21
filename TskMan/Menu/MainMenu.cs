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
<<<<<<< HEAD
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
=======
                Console.WriteLine("0 : Create new task.");
                Console.WriteLine("1 : Show all tasks.");
                Console.WriteLine("2 : View details.");
                Console.WriteLine("3 : Delete task.");
                Console.WriteLine("4 : Exit.");
                Console.Write("Choose your option: ");
                return Enum.Parse<MenuOptions>(Console.ReadLine());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
>>>>>>> ca9b8b505946e048edf6d4b555579ebb5de1214e
                return MenuOptions.None;
            }
        }
    }
}