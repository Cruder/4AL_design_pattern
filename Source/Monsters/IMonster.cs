using System;
using System.Linq;

namespace Source
{
    public interface IMonster
    {
        bool Alive();
        int Damages();
        void ReceiveDamages(int damages);
    }
}
