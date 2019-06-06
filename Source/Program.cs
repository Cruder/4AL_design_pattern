using System;
using System.Collections;

namespace Source
{
    public interface IMenu
    {
        void PushMenu(IMenu menu);
        IMenu PopMenu();

        void Display();
        void HandleInput();
    }
}

namespace Source
{
    public class StackMenu : IMenu
    {
        Menus stackMenus;

        StackMenu(Menus stackMenus)
        {
            this.stackMenus = stackMenus;
        }

        void PushMenu(IMenu menu)
        {
            stackMenus.Push(menu);
        }

        IMenu PopMenu()
        {
            return stackMenus.Pop();
        }

        void Display()
        {
            Console.WriteLine("==== MAIN MENU ====\n1 - Play\n 2 - Exit");
        }

        void HandleInput()
        {
            if(true)
            {
                // Exit
                PopMenu();
            } else
            {
                //
            }
        }
    }
}

namespace Source
{
    public class Menus
    {
        Stack menus = new Stack();

        void PushMenu(IMenu menu)
        {
            menus.Push(menu);
        }

        IMenu PopMenu()
        {
            return menus.Pop();
        }

        void Display()
        {
            menus.Peek().Display();
        }
    }
}

namespace Source
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int Test()
        {
            return 1;
        }
    }
}
