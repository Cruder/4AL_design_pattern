namespace Source
{
    public interface IUnit
    {
        void ReceiveDamages(int damages);
        int Damages();

        bool Alive();
    }
}
