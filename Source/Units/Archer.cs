namespace Source {
    public class Archer : IUnit
    {
        private int health;
        private const int atkDamages = 7;

        public Archer(){
            this.health = 10;
        }

        public void ReceiveDamages(int damages){
            this.health -= damages;
        }

        public int Damages(){
            return atkDamages;
        }

        public bool Alive(){
            return this.health > 0;
        }
}
