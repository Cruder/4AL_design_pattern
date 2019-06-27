namespace Source
{
    public class Wizard : IUnit
    {
        private int health;
        private const int atkDamages = 10;

        public Wizard()
        {
            this.health = 7;
        }

        public void ReceiveDamages(int damages)
        {
            if(this.health > damages)
                this.health -= damages;
            else
                this.health = 0;
        }

        public int Damages()
        {
            return atkDamages;
        }

        public bool Alive()
        {
            return(this.health > 0);
        }
    }
}