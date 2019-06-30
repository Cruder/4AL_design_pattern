using System;

namespace Source
{
    public class WinMenu : StackMenu
{
        public WinMenu(Menus stackMenus) : base(stackMenus)
        {
        }

        public override void Display()
        {
            Console.WriteLine("======= Mob Battle ========\n\n\n==== You win ! ====\nPress Any button");
        }

        public override void HandleInput()
        {
            string choice = Console.ReadLine();
            switch(choice){
                default : PopMenu();
                    break;
            }
        }
    }
}
