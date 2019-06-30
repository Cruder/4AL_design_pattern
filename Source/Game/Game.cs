using System.Collections.Generic;

namespace Source
{
    public class Game
    {
        private int turn;
        private List<IMonster> monsters = new List<IMonster>();
        private City city = new City();

        public Game()
        {
            this.turn = 0;
            var monsterSetup = new MonsterSetup(monsters);
            monsterSetup.Setup();
        }

        public void Turn()
        {
            city.Turn();
        }

        public City GetCity()
        {
            return city;
        }

        public List<IMonster> MonsterList()
        {
            return monsters;
        }
    }
}
