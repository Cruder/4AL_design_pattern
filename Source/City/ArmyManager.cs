using System.Collections.Generic;

namespace Source
{
    public class ArmyManager
    {
        private List<IUnit> unitStack = new List<IUnit>();

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

        public IUnit[] ExportUnits()
        {
            var units = unitStack.ToArray();
            unitStack.Clear();
            return units;
        }

        public void ImportUnits(IUnit[] units)
        {
            foreach(var unit in units)
            {
                unitStack.Add(unit);
            }
        }
    }
}
