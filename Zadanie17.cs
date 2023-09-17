using System;
class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] array = new int[10000];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(0, 10001);
        }
        int count = 0;
        int maxSum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                int mul = array[i] * array[j];
                int sum = array[i] + array[j];
                if (mul % 14 != 0)
                {
                    count++;
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }
        }
        Console.WriteLine($"Количество пар с произведением, делющимся на 10: {count}");
        Console.WriteLine($"Максимальная сумма элементов в таких парах: {maxSum}");
    }
}