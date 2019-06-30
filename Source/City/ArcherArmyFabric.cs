using System.Collections.Generic;

namespace Source
{
    public class ArcherArmyFabric : IArmyFabric
    {
        public Army CreateArmy(int n)
        {
            IUnit[] arr = new IUnit[n];
            for(int i = 0; i < n; i++)
                arr[i] = new Archer();

            Army army = new Army(arr);
            return army;//TODO : retourne un array de commande --> faire les commandes qui dure le temps des tours
        }
    }
}
