// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.

// Начальные условия
int[,] numbers = new int[,]
{
    {1, 2, 3},
    {1, 1, 0},
    {7, 8, 2},
    {9, 10, 11}

};
Printnumbers();
void Printnumbers() //вывод массива
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[] SumRows(int[,] array)
{
    int[] sums = new int[numbers.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sums[i] += numbers[i,j];

        }
    }
    return sums;
}


int MinIndex(int[] array)                        // Получение индекса минимального элемента в одномерном массиве
{
    int min = array[0];
    int MinIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            MinIndex = i;
        }

    }
    return MinIndex;
}


void PrintResult(int[,] numbers)
{
    int[] sums = SumRows(numbers);
    System.Console.WriteLine(MinIndex(sums));
}

PrintResult(numbers);

