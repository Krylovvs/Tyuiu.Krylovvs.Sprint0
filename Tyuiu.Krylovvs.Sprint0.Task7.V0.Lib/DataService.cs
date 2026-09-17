namespace Tyuiu.Krylovvs.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] Num1, int[] Num2)
        {
            if (Num1.Length != Num2.Length)
            {
                throw new ArgumentException("Массивы разных размеров");
            }
                
            int[] ResArr = new int[Num1.Length];
            
            for (int i = 0; i < ResArr.Length; i++)
            {
                ResArr[i] = Num1[i] + Num2[i];
            }
            return ResArr;
        }
    }
}
