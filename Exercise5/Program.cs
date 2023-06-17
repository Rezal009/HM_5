// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] arr = new int[10]; // Задайте размер массива, например, 10

        // Заполнение массива случайными числами
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(1, 100); // Генерация случайного числа в диапазоне [1, 100]
        }

        Console.Write("Массив: ");
        PrintArray(arr);

        int[] productArray = new int[arr.Length / 2];

        for (int i = 0; i < arr.Length / 2; i++)
        {
            productArray[i] = arr[i] * arr[arr.Length - 1 - i];
        }

        Console.Write("Произведения пар чисел: ");
        PrintArray(productArray);
    }

    static void PrintArray(int[] arr)
    {
        Console.Write("[ ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine("]");
    }
}



