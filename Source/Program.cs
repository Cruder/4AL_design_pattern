using System;
using System.Collections;
namespace Source
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menus menu = new Menus(new Game());
            menu.PushMenu(new MainMenu(menu));

            while(!menu.Empty())
            {
                menu.Display();
                menu.HandleInput();
            }
        }

        public int Test()
        {
            return 1;
        }
    }
}
