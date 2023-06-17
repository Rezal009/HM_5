// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

using System;

class Program
{
    static void Main()
    {
        int[] array = new int[123];
        FillRandomArray(array);
        Console.WriteLine("Массив: ");
        PrintArray(array);

        int count = CountInRange(array, 10, 99);
        Console.WriteLine($"Количество элементов в диапазоне [10, 99]: {count}");
    }

    static void FillRandomArray(int[] array)
    {
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 200);
        }
    }

    static void PrintArray(int[] array)
    {
        Console.Write("[ ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.Write("]");
        Console.WriteLine();
    }

    static int CountInRange(int[] array, int min, int max)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= min && array[i] <= max)
                count++;
        }
        return count;
    }
}
