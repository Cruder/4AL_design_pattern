using System;

namespace Source
{
    public class Battle : IExpeditionStep
    {
        IUnit army;
        IMonster monster;

        public Battle(IUnit army, IMonster monster)
        {
            this.army = army;
            this.monster = monster;
        }

        public void Turn()
        {
            monster.ReceiveDamages(army.Damages());
            army.ReceiveDamages(monster.Damages());
        }

        public bool Finished()
        {
            return !army.Alive() || !monster.Alive();
        }
    }
}
