namespace Source
{
    namespace Monsters
    {
        public class Giant : IMonster
        {
            public int Damages()
            {
                return 1;
            }

            public void ReceiveDamages(int damages)
            {
            }

            public bool Alive()
            {
                return true;
            }
        }
    }
}
