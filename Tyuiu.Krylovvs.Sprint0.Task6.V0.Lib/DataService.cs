namespace Tyuiu.Krylovvs.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static object AdditionArray(int[] Nums) {
            var Total = 0;
            foreach(var num in Nums)
            {
                Total += num;   
            }
            return Total;
        }
        public static object SubtractionArray(int[] Nums) {
            var Total = 0;
            foreach (var num in Nums)
            {
                Total -= num;
            }
            return Total;
        }
        public static object MultiplicationArray(int[] Nums) {
            var Total = 1;
            int index = 0;
            do
            {
                Total *= Nums[index];
                index++;
            }
            while (index < Nums.Length);

            return Total;
        }
    }
}
