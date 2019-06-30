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
            monsters.RemoveAll(monster => !monster.Alive());
        }

        public List<IMonster> ToList()
        {
            return monsters;
        }

        public bool IsEmpty()
        {
            return monsters.Count == 0;
        }
    }
}
