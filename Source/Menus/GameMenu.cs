using System;

namespace Source
{
    public class GameMenu : StackMenu
    {
        public GameMenu(Menus stackMenus) : base(stackMenus)
        {
        }

        public override void Display()
        {
            Console.WriteLine("==== Game MENU ====\n 1 - Build unit\n 2 - Build Ressources\n 3 - Ressources unit\n 4 - Attack\n 5 - Quit");
        }

        public override void HandleInput()
        {
            string choice = Console.ReadLine();
            switch(choice){
                case "1" : PushMenu(new UnitMenu(stackMenus)); 
                    break;
                // case "2" : PushMenu(); 
                //     break;
                // case "3" : PushMenu(); 
                //     break;
                // case "4" : PushMenu(); 
                //     break;
                case "5" : PopMenu(); 
                    break;

                default : this.Display();
                    break;

            }
        }
    }
}