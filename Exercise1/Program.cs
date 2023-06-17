// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

    class Program
{
    static Random random = new Random();

    static void Main()
    {
        Console.WriteLine("Введите размер массива:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[size];
        FillArrayRandomNumbers(numbers);
        Console.WriteLine("Вот наш массив:");
        PrintArray(numbers);

        int count = CountEvenNumbers(numbers);
        Console.WriteLine($"Всего {numbers.Length} чисел, {count} из них чётные");
    }

    static void FillArrayRandomNumbers(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(100, 1000);
        }
    }

    static void PrintArray(int[] numbers)
    {
        Console.Write("[ ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.Write("]");
        Console.WriteLine();
    }

    static int CountEvenNumbers(int[] numbers)
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
}
    