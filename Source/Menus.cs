using System.Collections;

namespace Source
{
    public class Menus
    {
        Stack menus = new Stack();

        public void PushMenu(IMenu menu)
        {
            menus.Push(menu);
        }

        public IMenu PopMenu()
        {
            return (IMenu)menus.Pop();
        }

        public void Display()
        {
            CurrentMenu().Display();
        }

        public void HandleInput()
        {
            CurrentMenu().HandleInput();
        }

        public bool Empty()
        {
            return menus.Count == 0;
        }

        private IMenu CurrentMenu()
        {
            return ((IMenu)menus.Peek());
        }
    }
}
