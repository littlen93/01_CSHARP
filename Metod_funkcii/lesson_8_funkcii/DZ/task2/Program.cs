// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.


int[] numbers = new int[10];
Random rnd = new Random();

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int R = rnd.Next(100, 1000);
        array[i] = R;
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}

int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

FillArray(numbers);
PrintArray(numbers);

System.Console.WriteLine("\n" + CountEvenNumbers(numbers));