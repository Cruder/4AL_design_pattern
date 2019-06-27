namespace Source
{
    public class Food : IResources
    {

        private int quantity;
        private const int PRODUCTIVITY = 10;//TODO équilibrage du jeu

        public Food()
        {
            this.quantity = 0;
        }

        public void Consume(int amount)
        {
            this.quantity -= amount;
        }

        public void Produce()
        {
            this.quantity += PRODUCTIVITY;
        }

        public int GetAmount()
        {
            return this.quantity;
        }

        public bool IsLow()
        {
            return(this.quantity < 10);
        }
    }
}
