using Tyuiu.Krylovvs.Sprint0.Task7.V0.Lib;

namespace Tyuiu.Krylovvs.Sprint0.Task7.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArraysValid()
        {
            int[] Num1 = new int[] { 1, 1, 1, 1, 1 };
            int[] Num2 = new int[] { 1, 1, 1, 1, 1 };
            int[] Expected = new int[] { 2, 2, 2, 2, 2 };

            int[] Res = DataService.AdditionArrays(Num1, Num2);
            CollectionAssert.AreEqual(Expected, Res);
        }
    }
}
