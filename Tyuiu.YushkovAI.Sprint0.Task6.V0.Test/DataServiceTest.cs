using Tyuiu.YushkovAI.Sprint0.Task6.V0.Lib;

namespace Tyuiu.YushkovAI.Sprint0.Task6.V0.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void CheckAdditionArrayValid()
    {
        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var result = DataService.AdditionArray(numbers);

        Assert.AreEqual(15, result);
    }

    [TestMethod]
    public void CheckSubstractionArrayValid()
    {
        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var result = DataService.SubtractionArray(numbers);

        Assert.AreEqual(-15, result);
    }

    [TestMethod]
    public void CheckMultArrayValid()
    {
        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var result = DataService.MultiplicationArray(numbers);

        Assert.AreEqual(120, result);
    }
}
