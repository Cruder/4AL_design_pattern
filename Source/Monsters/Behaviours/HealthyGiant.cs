namespace Source
{
    public class HealthyGiant : IBehaviour
    {
        int activationThreshold;

        public HealthyGiant(int activationThreshold)
        {
            this.activationThreshold = activationThreshold;
        }

        public int Damages()
        {
            return 3;
        }

        public int ReceiveDamages(int damages)
        {
            return damages;
        }

        public bool Active(int live)
        {
            return live > activationThreshold;
        }
    }
}
