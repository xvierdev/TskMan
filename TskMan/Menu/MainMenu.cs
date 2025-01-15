using System;
using TskMan.Menu.Enums;
namespace TskMan.Menu
{
    static class MainMenu
    {
        public static MenuOptions Show()
        {
            Console.WriteLine("0 : Create new task.");
            Console.WriteLine("1 : Show all tasks.");
            Console.WriteLine("2 : View details.");
            Console.WriteLine("3 : Delete task.");
            Console.WriteLine("4 : Exit.");
            Console.Write("Choose your option: ");
            return Enum.Parse<MenuOptions>(Console.ReadLine());
        }
    }
}