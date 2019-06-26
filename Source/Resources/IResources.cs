namespace Source{
    public interface IResources{
        void consume(int amount);
        void produce();
        int getAmount();
        bool isLow();
    }
}