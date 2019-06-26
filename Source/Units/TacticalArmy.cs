using System;

namespace Source
{
    public class TacticalArmy : IUnit
    {
        IUnit firstLine;
        IUnit lastLine;

        public TacticalArmy(IUnit[] firstLine, IUnit[] lastLine)
        {
            this.firstLine = new Army(firstLine);
            this.lastLine = new Army(lastLine);
        }

        public void ReceiveDamages(int damages)
        {
            if(firstLine.Alive())
            {
                firstLine.ReceiveDamages(damages);
            }
            else
            {
                lastLine.ReceiveDamages(damages);
            }
        }

        public int Damages()
        {
            return firstLine.Damages() + lastLine.Damages();
        }

        public bool Alive()
        {
            return firstLine.Alive() && lastLine.Alive();
        }
    }
}
