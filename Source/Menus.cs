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
            ((IMenu)menus.Peek()).Display();
        }
    }
}
