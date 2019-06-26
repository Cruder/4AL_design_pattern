namespace Source
{
    public class WoundedGiant : IBehaviour
    {
        int activationThreshold;

        WoundedGiant(int activationThreshold)
        {
            this.activationThreshold = activationThreshold;
        }

        public int Damages()
        {
            return 5;
        }

        public int ReceiveDamages(int damages)
        {
            return damages * 2;
        }

        public bool Active(int live)
        {
            return live > activationThreshold;
        }
    }
}
