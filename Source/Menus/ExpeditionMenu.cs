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
                ""
            );
        }

        public override void HandleInput()
        {
        }

        private String Monsters()
        {
            var monsters = CurrentGame().MonsterList();
            return monsters
                .Select((monster, index) => "{0} [{1}] - {2}")
                .Aggregate((current, next) => current + "\n" + next);
        }
    }
}
