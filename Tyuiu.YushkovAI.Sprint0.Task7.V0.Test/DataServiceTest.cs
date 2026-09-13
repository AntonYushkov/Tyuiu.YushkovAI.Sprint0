using Tyuiu.YushkovAI.Sprint0.Task7.V0.Lib;

namespace Tyuiu.YushkovAI.Sprint0.Task7.V0.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void CheckAdditionArraysValid()
    {
        int[] nums1 = new int[] { 1, 1, 1, 1, 1 };
        int[] nums2 = new int[] { 1, 1, 1, 1, 1 };
        int[] expected = new int[] { 2, 2, 2, 2, 2 };

        int[] result = DataService.AdditionArrays(nums1, nums2);

        CollectionAssert.AreEqual(expected, result);
    }
}
