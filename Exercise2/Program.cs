// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов массива: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] randomArray = new int[size];

        FillRandomArray(randomArray, size);
        Console.WriteLine("\nМассив: ");
        PrintArray(randomArray);

        int sum = CalculateOddPositionSum(randomArray);
        Console.WriteLine($"\nСумма элементов, стоящих на нечетных позициях: {sum}");
    }

    static void FillRandomArray(int[] array, int size)
    {
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 9);
        }
    }

    static void PrintArray(int[] array)
    {
        Console.Write("[ ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine("]");
    }

    static int CalculateOddPositionSum(int[] array)
    {
        int sum = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }
        return sum;
    }
}
