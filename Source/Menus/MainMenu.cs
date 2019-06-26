using System;

namespace Source{
    public class MainMenu : StackMenu{
        public MainMenu(Menus stackMenus) : base(stackMenus)
        {
        }

        public override void Display()
        {
            Console.WriteLine("======= Mob Battle ========\n\n\n==== MAIN MENU ====\n1 - Play\n2 - Exit");
        }

        public override void HandleInput()
        {
            string choice = Console.ReadLine();
            switch(choice){
                case "1" : PushMenu(new GameMenu(stackMenus)); 
                    break;
                case "2" : PopMenu(); 
                    break;

                default : Display();
                    break;

            }
        }
    }
}
