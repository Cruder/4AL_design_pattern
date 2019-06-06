using System;
using System.Linq;

namespace Source
{
    public class Battle
    {
        IUnit[] army;
        IMonster monster;

        Battle(IUnit[] army, IMonster monster)
        {
            this.army = army;
            this.monster = monster;
        }

        public void Turn()
        {
            foreach(var unit in army)
            {
                monster.ReceiveDamages(unit.Damages());
                unit.ReceiveDamages(monster.Damages());
            }

            army = army.Where(unit => unit.Alive()).ToArray();
        }

        public bool Finished()
        {
            return army.Length == 0 || !monster.Alive();
        }

        public IUnit[] RemainingUnits()
        {
            return army;
        }
    }
}
