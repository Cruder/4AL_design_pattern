using System;

namespace Source
{
    class Army
    {
        IUnit[] units;

        Army(IUnit[] units)
        {
            this.units = units;
        }
    }
}