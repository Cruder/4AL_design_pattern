using System;

namespace Source
{
    public abstract class StackMenu : IMenu
    {
        public Menus stackMenus;

        public StackMenu(Menus stackMenus)
        {
            this.stackMenus = stackMenus;
        }

        public void PushMenu(IMenu menu)
        {
            stackMenus.PushMenu(menu);
        }

        public IMenu PopMenu()
        {
            return stackMenus.PopMenu();
        }

        public void Display()
        {
            Console.WriteLine("==== MAIN MENU ====\n1 - Play\n2 - Exit");
        }

        public abstract void HandleInput();
        
    }
}
