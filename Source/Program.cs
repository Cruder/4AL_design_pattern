using System;
using System.Collections;
namespace Source
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menus menu = new Menus();
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

//https://prod.liveshare.vsengsaas.visualstudio.com/join?7F4952070B3F53432A62D8FA0200F91BFD16