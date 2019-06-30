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
            Console.WriteLine(
                "==== City State ====\n" +
                "==Resources==\n" +
                " - Gold : " + this.CurrentGame().GetCity().GetGold().GetAmount() + "\n" +
                " - Wood : " + this.CurrentGame().GetCity().GetFood().GetAmount() + "\n" +
                "==== Game MENU ====\n"+
                 "1 - Build unit\n" +
                 "2 - Attack\n" +
                 "3 - Next turn\n" +
                 "-1 - Quit");
        }

        public override void HandleInput()
        {
            string choice = Console.ReadLine();
            switch(choice){
                case "1" : PushMenu(new UnitMenu(stackMenus));
                    break;
                case "2" : PushMenu(new ExpeditionMenu(stackMenus));
                    break;
                case "3" : this.CurrentGame().Turn();
                    break;
                case "-1" : PopMenu();
                    break;

                default : this.Display();
                    break;

            }
        }
    }
}