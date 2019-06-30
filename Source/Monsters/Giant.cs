using System;

namespace Source
{
    public class Giant : IMonster
    {
        int lives;
        IBehaviourManager behaviourManager;
        int distance;
        string name;

        public Giant(IBehaviourManager behaviourManager, int distance, string name)
        {
            this.lives = 10;
            this.behaviourManager = behaviourManager;
            this.distance = distance;
            this.name = name;
        }

        public int Damages()
        {
            return CurrentState().Damages();
        }

        public void ReceiveDamages(int damages)
        {
            this.lives -= CurrentState().ReceiveDamages(damages);
        }

        public bool Alive()
        {
            return this.lives > 0;
        }

        public int Distance()
        {
            return distance;
        }

        public String Name()
        {
            return name;
        } 

        private IBehaviour CurrentState()
        {
            return behaviourManager.CurrentState(lives);
        }
    }
}
