using Tyuiu.YushkovAI.Sprint0.Task6.V0.Lib;

namespace Tyuiu.YushkovAI.Sprint0.Task6.V0;

class Program
{
    static void Main()
    {
        int[] numsArray = { 1, 2, 3, 4, 5 };

        Console.WriteLine(
            "Сумма элементов массива = " +
            DataService.AdditionArray(numsArray));

        Console.WriteLine(
            "Разность элементов массива = " +
            DataService.SubtractionArray(numsArray));

        Console.WriteLine(
            "Произведение элементов массива = " +
            DataService.MultiplicationArray(numsArray));
    }
}
