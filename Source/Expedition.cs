using System;

namespace Source
{
    public class Expedition
    {
        IUnit[] army;
        IMonster monster;

        int duration;

        Expedition(IUnit[] army, IMonster monster, int duration)
        {
            this.army = army;
            this.monster = monster;
            this.duration = duration;
        }

        public void Turn()
        {
            duration -= 1;
        }

        public bool Finished()
        {
            return duration <= 0;
        }

        public IUnit[] RemainingUnits()
        {
            return army;
        }
    }
}
