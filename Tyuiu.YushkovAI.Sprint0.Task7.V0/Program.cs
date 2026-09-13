using Tyuiu.YushkovAI.Sprint0.Task7.V0.Lib;

namespace Tyuiu.YushkovAI.Sprint0.Task7.V0;

class Program
{
    static void Main(string[] args)
    {
        int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };
        int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };

        Console.WriteLine("Массив №1:");

        for (int i = 0; i < arrayNums1.Length; i++)
        {
            Console.Write(arrayNums1[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine("Массив №2:");

        for (int i = 0; i < arrayNums2.Length; i++)
        {
            Console.Write(arrayNums2[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine();

        if (arrayNums1.Length == arrayNums2.Length)
        {
            int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);

            Console.WriteLine("Результат сложения:");

            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.Write(resultArray[i] + " ");
            }

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Ошибка: массивы имеют разную длину.");
        }
    }
}
