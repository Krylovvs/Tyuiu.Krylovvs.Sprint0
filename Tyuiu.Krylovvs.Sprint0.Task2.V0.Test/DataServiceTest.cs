using Tyuiu.Krylovvs.Sprint0.Task2.V0.Lib;

namespace Tyuiu.Krylovvs.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var Name = "HUH";
            var Result = DataService.GetMessage(Name);
            var Expected = "Was up, HUH";

            Assert.AreEqual(Expected, Result);
        }
    }
}
