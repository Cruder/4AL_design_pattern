using System;

namespace Source
{
    public class Giant : IMonster
    {
        int lives;
        IBehaviourManager behaviourManager;

        public Giant(IBehaviourManager behaviourManager)
        {
            this.lives = 10;
            this.behaviourManager = behaviourManager;
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

        private IBehaviour CurrentState()
        {
            return behaviourManager.CurrentState(lives);
        }
    }
}
