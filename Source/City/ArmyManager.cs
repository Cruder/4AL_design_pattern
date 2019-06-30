using System.Collections.Generic;

namespace Source
{
    public class ArmyManager
    {
        private List<Army> unitStack = new List<Army>();

        public void CreateWizardsArmy(int wizards)
        {
            this.unitStack.Add(new WizardArmyFabric().CreateArmy(wizards));
        }

        public void CreateKnightsArmy(int knights)
        {
            this.unitStack.Add(new KnightArmyFabric().CreateArmy(knights));
        }

        public void CreateArcherArmy(int archers)
        {
            this.unitStack.Add(new ArcherArmyFabric().CreateArmy(archers));
        }
    }
}
