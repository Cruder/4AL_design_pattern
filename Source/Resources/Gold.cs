namespace Source{
    public class Gold : IResources{

        private int quantity;
        private const int PRODUCTIVITY = 1;//TODO équilibrage du jeu

        public Gold(){
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