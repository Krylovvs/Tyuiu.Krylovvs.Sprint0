using Tyuiu.Krylovvs.Sprint0.Task6.V0.Lib;

int[] Arr = new int[] { 1, 2, 3, 4, 5 };

Console.WriteLine("Сумма штук = " + DataService.AdditionArray(Arr));
Console.WriteLine("Разность штук = " + DataService.SubtractionArray(Arr));
Console.WriteLine("Произведение штук = " + DataService.MultiplicationArray(Arr));

Console.ReadKey();