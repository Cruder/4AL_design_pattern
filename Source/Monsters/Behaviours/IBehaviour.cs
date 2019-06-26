namespace Source
{
    public interface IBehaviour
    {
        int Damages();
        int ReceiveDamages(int damages);
        bool Active(int live);
    }
}
