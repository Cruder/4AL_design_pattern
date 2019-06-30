using System;

namespace Source
{
    public class UnitMenu : StackMenu
    {
        public UnitMenu(Menus stackMenus) : base(stackMenus)
        {
        }

        public override void Display()
        {
            Console.WriteLine("==== Unit MENU ====\n 1 - Build archers\n 2 - Build knights\n 3 - Build wizards\n 4 - Quit");
        }

        public override void HandleInput()
        {
            string choice = Console.ReadLine();
            ArmyManager build = CurrentGame().GetCity().GetArmies();
            switch(choice){
                case "1" :
                    build.CreateArcherArmy(unitNumber());
                    break;
                case "2" :
                    build.CreateKnightsArmy(unitNumber());
                    break;
                case "3" :
                    build.CreateWizardsArmy(unitNumber());
                    break;
                case "4" : PopMenu();
                    break;

                default : this.Display();
                    break;

            }
        }

        public int unitNumber(){
            Console.WriteLine("How many ?");
            string nbr = Console.ReadLine();
            return Convert.ToInt32(nbr);
        }
    }
}