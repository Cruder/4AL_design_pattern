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
            int nbr;
            string choice = Console.ReadLine();
            City city = CurrentGame().GetCity();
            ArmyManager build = CurrentGame().GetCity().GetArmies();
            switch(choice){
                case "1" :
                    nbr = unitNumber();
                    city.SetGold(new Gold(city.GetGold().GetAmount()-nbr));
                    city.SetFood(new Food(city.GetFood().GetAmount()-10*nbr));
                    build.CreateArcherArmy(nbr);
                    break;
                case "2" :
                    nbr = unitNumber();
                    city.SetGold(new Gold(city.GetGold().GetAmount()-nbr));
                    city.SetFood(new Food(city.GetFood().GetAmount()-5*nbr));
                    build.CreateKnightsArmy(nbr);
                    break;
                case "3" :
                    nbr = unitNumber();
                    city.SetGold(new Gold(city.GetGold().GetAmount()-nbr*2));
                    city.SetFood(new Food(city.GetFood().GetAmount()-12*nbr));
                    build.CreateWizardsArmy(nbr);
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