using System.Collections.Generic;

namespace Source{
    public class ArcherArmyFabric : IArmyFabric
    {
        public Army createArmy(int n){
            IUnit[] arr = new IUnit[n];            
            for(int i = 0; i < n; i++){
                arr[i] = new Archer();
            }
            Army army = new Army(arr);
            return army;
        }
    }
}
