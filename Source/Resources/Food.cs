namespace Source{
    public class Food : IResources{

        private int quantity;
        private const int PRODUCTIVITY = 10;//TODO équilibrage du jeu

        public Food(){
            this.quantity = 0;
        }

        public void consume(int amount){
            this.quantity -= amount;
        }
        public void produce(){
            this.quantity += PRODUCTIVITY;
        }
        public int getAmount(){
            return this.quantity;
        }
        public bool isLow(){
            return(this.quantity < 10);
        }
    }
}