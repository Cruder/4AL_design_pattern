using System.Collections.Generic;

namespace Source{
    public class ArmyManager{
        private Stack<Army> unitStack = new  Stack<Army>();

        public ArmyManager(){

        }

        public void CreateWizardsArmy(int wizards){
            this.unitStack.Push(new WizardArmyFabric().createArmy(wizards));
        }

        public void CreateKnightsArmy(int knights){
            this.unitStack.Push(new KnightArmyFabric().createArmy(knights));
        }

        public void CreateArcherArmy(int archers){
            this.unitStack.Push(new ArcherArmyFabric().createArmy(archers));
        }

    }
}