using System;
using System.Linq;

namespace Source
{
    public class ExpeditionMenu : StackMenu
    {
        public ExpeditionMenu(Menus stackMenus) : base(stackMenus)
        {
        }

        public override void Display()
        {
            Console.WriteLine(
                "==== Expedition Menu ====\n" +
                "-- Monster List --\n" +
                Monsters() +
                "\n-1 - Quit"
            );
        }

        public override void HandleInput()
        {
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "-1" : PopMenu();
                    break;
                default :
                    int choiceNumber;
                    Console.WriteLine($"{choice}, {int.TryParse(choice, out choiceNumber)}");
                    if(int.TryParse(choice, out choiceNumber) && choiceNumber >= 0 && choiceNumber < CurrentGame().MonsterList().Count)
                    {
                        var monster = CurrentGame().MonsterList()[choiceNumber];
                        var army = CurrentGame().GetCity().GetArmies().ExportUnits();

                        var builder = new ExpeditionBuilder(
                            monster,
                            new Army(army),
                            CurrentGame().GetCity()
                        );
                        builder.AddTravel().AddBattle().BackHome();
                        CurrentGame().AddExpedition(builder.Release());

                        PopMenu();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.\n");
                        this.Display();
                    }
                    break;
            }
        }

        private String Monsters()
        {
            var monsters = CurrentGame().MonsterList();
            return monsters
                .Select((monster, index) => $"{index} [{monster.Distance()}] - {monster.Name()}")
                .Aggregate((current, next) => current + "\n" + next);
        }
    }
}
