namespace Source{
    public interface IResources{
        void Consume(int amount);
        void Produce();
        int GetAmount();
        bool IsLow();
    }
}