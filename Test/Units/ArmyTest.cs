using Microsoft.VisualStudio.TestTools.UnitTesting;

using Source;

namespace Test
{
    [TestClass]
    public class ArmyTest
    {
        [TestMethod]
        public void NotAliveWhenCreatedEmpty()
        {
            IUnit army = new Army(new IUnit[0]);

            Assert.AreEqual(army.Alive(), false);
        }

        [TestMethod]
        public void AliveWhenCreatedWithAliveUnits()
        {
            IUnit archer = new Archer();
            IUnit army = new Army(new IUnit[] { archer });

            Assert.AreEqual(army.Alive(), true);
        }

        [TestMethod]
        public void NotAliveWhenCreatedWithDeadUnits()
        {
            IUnit archer = new Archer();
            archer.ReceiveDamages(10);

            IUnit army = new Army(new IUnit[] { archer });

            Assert.AreEqual(army.Alive(), false);
        }

        [TestMethod]
        public void AliveWhenReceiveSomeMuchDamages()
        {
            IUnit archer = new Archer();
            IUnit army = new Army(new IUnit[] { archer });

            army.ReceiveDamages(1);

            Assert.AreEqual(army.Alive(), true);
        }

        [TestMethod]
        public void NotAliveWhenReceiveTooMuchDamages()
        {
            IUnit archer = new Archer();
            IUnit army = new Army(new IUnit[] { archer });

            army.ReceiveDamages(10);

            Assert.AreEqual(army.Alive(), false);
        }

        [TestMethod]
        public void ZeroDamageWhenNoUnits()
        {
            IUnit army = new Army(new IUnit[0]);

            Assert.AreEqual(army.Damages(), 0);
        }

        [TestMethod]
        public void UnitDamageWhenOneUnits()
        {
            IUnit archer = new Archer();
            IUnit army = new Army(new IUnit[] { archer });

            Assert.AreEqual(army.Damages(), 7);
        }

        [TestMethod]
        public void UnitDamagesWhenMultiplesUnits()
        {
            IUnit archer = new Archer();
            IUnit army = new Army(new IUnit[] { archer, archer });

            Assert.AreEqual(army.Damages(), 14);
        }
    }
}
