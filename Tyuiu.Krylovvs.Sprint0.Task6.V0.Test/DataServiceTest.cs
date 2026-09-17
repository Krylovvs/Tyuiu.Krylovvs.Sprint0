using Tyuiu.Krylovvs.Sprint0.Task6.V0.Lib;

namespace Tyuiu.Krylovvs.Sprint0.Task6.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [DataTestMethod]
        [DataRow(new[] { 1, 2, 3, 4, 5 }, 15)]
        [DataRow(new[] { -1, 2, -3 }, -2)]
        [DataRow(new[] { 0, 10, 20 }, 30)]
        [DataRow(new int[0], 0)]
        public void CheckAdditionArrayValid(int[] Numbers, int Expected) {
            var Res = DataService.AdditionArray(Numbers);
            Assert.AreEqual(Expected, Res);
        }

        [DataTestMethod]
        [DataRow(new[] { 1, 2, 3, 4, 5 }, -15)]
        [DataRow(new[] { -1, 2, -3 }, 2)]
        [DataRow(new[] { 0, 10, 20 }, -30)]
        [DataRow(new int[0], 0)]
        public void CheckSubstractionArrayValid(int[] Numbers, int Expected) {
            var Res = DataService.SubtractionArray(Numbers);
            Assert.AreEqual(Expected, Res);
        }

        [DataTestMethod]
        [DataRow(new[] { 1, 2, 3, 4, 5 }, 120)]
        [DataRow(new[] { -2, 3, 4 }, -24)]
        [DataRow(new[] { 0, 10, 20 }, 0)]
        [DataRow(new[] { 7 }, 7)]
        public void CheckMultArrayValid(int[] Numbers, int Expected) {
            var Res = DataService.MultiplicationArray(Numbers);
            Assert.AreEqual(Expected, Res);
        }


    }
}
