// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов массива: ");
        int size = Convert.ToInt32(Console.ReadLine());
        double[] randomArray = new double[size];

        FillRandomArray(randomArray, size);
        Console.WriteLine("\nМассив: ");
        PrintArray(randomArray);

        double difference = CalculateDifference(randomArray);
        Console.WriteLine($"\nРазница между максимальным и минимальным элементами массива: {difference:F2}");
    }

    static void FillRandomArray(double[] array, int size)
    {
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            array[i] = random.NextDouble();
        }
    }

    static void PrintArray(double[] array)
    {
        Console.Write("[ ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]:F2} ");
        }
        Console.WriteLine("]");
    }

    static double CalculateDifference(double[] array)
    {
        double min = array[0];
        double max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
                min = array[i];
            if (array[i] > max)
                max = array[i];
        }

        return max - min;
    }
}

