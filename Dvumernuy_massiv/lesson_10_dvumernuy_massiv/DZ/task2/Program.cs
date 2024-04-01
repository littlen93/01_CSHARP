// Задача 2: Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.

// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};

// Печать массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// Обмен первой с последней строкой
int[,] SwapFirstLastRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        SwapItems(array, i);
    }
    return array;
}

// Обмен элементами массива
void SwapItems(int[,] array, int i)
{
    int temp = array[0, i];
    array[0, i] = array[array.GetLength(0) - 1, i];
    array[array.GetLength(0) - 1, i] = temp;
}

void PrintResult(int[,] numbers)
{
    PrintArray(SwapFirstLastRows(numbers));
}

PrintResult(numbers);