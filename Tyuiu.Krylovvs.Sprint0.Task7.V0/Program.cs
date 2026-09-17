using System.Text;
using Tyuiu.Krylovvs.Sprint0.Task7.V0.Lib;


int[] Num1 = new int[] { 1, 2, 3, 4};
int[] Num2 = new int[] { 1, 2, 3, 4, 5 };
int[] Res = DataService.AdditionArrays(Num1, Num2);


Console.Title = "Спринт #0 | Выполнил: Крылов В.С. | ПИНб-26-1";
//huh
var Text = File.ReadAllText(@"Content\Epilog.txt", Encoding.UTF8);

var Outer = Text.Replace("{{ENTER_DATA1_ARRAY}}",string.Join(", ", Num1))
    .Replace("{{ENTER_DATA2_ARRAY}}", string.Join(", ", Num2))
    .Replace("{{OUT_DATA_ARRAY}}", string.Join(", ", Res));

Console.WriteLine(Outer);
Console.ReadKey();