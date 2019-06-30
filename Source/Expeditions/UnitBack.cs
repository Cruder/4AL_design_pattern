using System;

namespace Source
{
    public class UnitBack : IExpeditionStep
    {
        private City city;
        private IUnit army;
        private bool executed;

        public UnitBack(City city, IUnit army)
        {
            this.city = city;
            this.army = army;
            this.executed = false;
        }

        public void Turn()
        {
            if(executed) { return; }

            city.GetArmies().ImportUnits(new IUnit[] { army });

            executed = true;
        }

        public bool Finished()
        {
            return executed;
        }
    }
}
