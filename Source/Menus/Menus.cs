using System.Collections;

namespace Source
{
    public class Menus
    {
        Stack menus = new Stack();
        Game game;

        public Menus(Game game)
        {
            this.game = game;
        }

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

        public Game Game()
        {
            return game;
        }

        private IMenu CurrentMenu()
        {
            return ((IMenu)menus.Peek());
        }
    }
}
