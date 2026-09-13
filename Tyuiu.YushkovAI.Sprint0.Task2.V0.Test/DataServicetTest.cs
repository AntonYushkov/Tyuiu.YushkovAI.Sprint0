using Tyuiu.YushkovAI.Sprint0.Task2.V0.Lib;

namespace Tyuiu.YushkovAI.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Антон";
            var res = DataService.GetMessage(name);

            Assert.AreEqual($"Привет, Антон", res);
        }
    }
}