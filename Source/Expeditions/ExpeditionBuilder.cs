using System;
using System.Collections.Generic;

namespace Source
{
    public class ExpeditionBuilder
    {
        private IMonster target;
        private IUnit army;
        private City city;

        private Expedition expedition;

        public ExpeditionBuilder(IMonster target, IUnit army, City city)
        {
            this.target = target;
            this.army = army;
            this.city = city;

            this.expedition = new Expedition();
        }

        public Expedition Release()
        {
            return expedition;
        }

        public ExpeditionBuilder AddTravel()
        {
            expedition.AddStep(new Travel(target.Distance()));
            return this;
        }

        public ExpeditionBuilder AddBattle()
        {
            expedition.AddStep(new Battle(army, target));
            return this;
        }

        public ExpeditionBuilder BackHome()
        {
            expedition.AddStep(new Travel(target.Distance()));
            expedition.AddStep(new UnitBack(city, army));
            return this;
        }
    }
}
