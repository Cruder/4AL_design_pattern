namespace Source{
    public class Knight : IUnit
    {
        private int health;
        private const int atkDamages = 5;
        public Knight(){
            this.health = 15;
        }

        public void ReceiveDamages(int damages){
            if(this.health > damages)
                this.health -= damages;
            else
                this.health = 0;
        }

        public int Damages(){
            return atkDamages;
        }

        public bool Alive(){
            return(this.health > 0);
        }
    }
}