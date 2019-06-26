using System.Collections.Generic;

namespace Source 
{
    public class MonsterSetup : ISetup
    {
        List<IMonster> monsters;

        public MonsterSetup(List<IMonster> monsters)
        {
            this.monsters = monsters;
        }

        public void Setup()
        {
            this.monsters.Add(SetupGiant(5, "Rocko"));
            this.monsters.Add(SetupGiant(10, "Flurdy"));
        }

        private IMonster SetupGiant(int distance, string name)
        {
            var behaviours = new IBehaviour[] { 
                new HealthyGiant(50), 
                new WoundedGiant(0)
            };
            var manager = new GiantBehaviourManager(behaviours);
            return new Giant(manager, distance, name);
        }
    }
}
