using System;
using System.Collections.Generic;

namespace Source
{
    public class Monsters
    {
        List<IMonster> monsters;

        public Monsters()
        {
            this.monsters = new List<IMonster>();
        }

        public void AddMonster(IMonster monster)
        {
            monsters.Add(monster);
        }

        public void Turn()
        {
            foreach(var monster in monsters)
            {
                Console.WriteLine($"Monster {monster.Name()} is alive? {monster.Alive()}");

            }

            monsters.RemoveAll(monster => !monster.Alive());
        }

        public List<IMonster> ToList()
        {
            return monsters;
        }
    }
}
