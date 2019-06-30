using System.Collections.Generic;

namespace Source
{
    public class City
    {
        private ArmyManager armies;
        private Gold gold;
        private Food food;

        public City()
        {
            this.armies = new ArmyManager();
            this.gold = new Gold();
            this.food = new Food();
        }

        public void Turn()
        {
            gold.Produce();
            food.Produce();
        }

        public Gold GetGold()
        {
            return gold;
        }

        public Food GetFood()
        {
            return food;
        }

        public ArmyManager GetArmies()
        {
            return armies;
        }

        public void SetGold(Gold gold)
        {
            this.gold=gold;
        }

        public void SetFood(Food food)
        {
            this.food=food;
        }

        public void SetArmies(ArmyManager armies)
        {
            this.armies=armies;
        }
    }
}
