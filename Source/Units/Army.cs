using System;

namespace Source
{
    public class Army : IUnit
    {
        IUnit[] units;

        public Army(IUnit[] units)
        {
            this.units = units;
        }

        public void ReceiveDamages(int damages)
        {
            foreach(var unit in units)
            {
                unit.ReceiveDamages(damages);
            }
        }

        public int Damages()
        {
            int damages = 0;
            foreach(var unit in units)
            {
                if (unit.Alive())
                {
                    damages += unit.Damages();
                }
            }

            return damages;
        }

        public bool Alive()
        {
            foreach(var unit in units)
            {
                if (unit.Alive()) { return true; }
            }

            return false;
        }
    }
}
