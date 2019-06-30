using Microsoft.VisualStudio.TestTools.UnitTesting;

using Source;

namespace Test
{
    [TestClass]
    public class BattleTest
    {
        private IMonster Giant()
        {
            IBehaviour[] behaviours = new IBehaviour[] { new HealthyGiant(0) };
            IBehaviourManager manager = new GiantBehaviourManager(behaviours);
            return new Giant(manager, 0, "Tester");
        }

        [TestMethod]
        public void NotFinishedWhenMonsterAndArmyAlive()
        {
            IUnit archer = new Archer();
            IUnit army = new Army(new IUnit[] { archer });
            IMonster monster = Giant();

            IExpeditionStep battle = new Battle(army, monster);

            Assert.AreEqual(battle.Finished(), false);
        }

        [TestMethod]
        public void FinishedWhenArmyEmpty()
        {
            IUnit army = new Army(new IUnit[0]);
            IMonster monster = Giant();

            IExpeditionStep battle = new Battle(army, monster);

            Assert.AreEqual(battle.Finished(), true);
        }

        [TestMethod]
        public void FinishedWhenMonsterNotAlive()
        {
            IUnit archer = new Archer();
            IUnit army = new Army(new IUnit[] { archer });
            IMonster monster = Giant();
            monster.ReceiveDamages(10);

            IExpeditionStep battle = new Battle(army, monster);

            Assert.AreEqual(battle.Finished(), true);
        }

        [TestMethod]
        public void UnitTakeDamagesOnTurn()
        {
            IUnit archer = new Archer();
            IUnit army = new Army(new IUnit[] { archer, new Archer(), new Archer(), new Archer() });
            IMonster monster = Giant();

            IExpeditionStep battle = new Battle(army, monster);

            Assert.AreEqual(battle.Finished(), false);
            Assert.AreEqual(monster.Alive(), true);
            Assert.AreEqual(archer.Alive(), true);
            battle.Turn();
            Assert.AreEqual(battle.Finished(), true);
            Assert.AreEqual(monster.Alive(), false);
            Assert.AreEqual(archer.Alive(), true);
        }
    }
}
