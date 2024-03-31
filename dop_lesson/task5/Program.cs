// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без строки и столбца

int[,] numbers = new int[5, 5];
Random rnd = new Random();

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = rnd.Next(1, 100);
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
PrintArray(numbers);
System.Console.WriteLine("====================");

int[] FindMinValue(int[,] arr)
{
    int[] ind = new int[2];
    int minValue = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < minValue)
            {
                minValue = arr[i, j];
                ind[0] = i;
                ind[1] = j;
            }
        }
    }
    return ind;
}

int[,] DeleteItems(int[,] number, int[]index)
{
    int[,] newArray = new int[number.GetLength(0)-1,number.GetLength(1)-1];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if (i < index[0] && j < index[1])
            {
                newArray[i,j] = number[i,j];
            }
            else if (i == index[0] || j == index[1])
            {
               continue;
            }
            else if(i < index[0] && j > index[1])
            {
                newArray[i,j-1] = number[i,j];
            }
            else if(i > index[0] && j < index[1])
            {
                newArray[i-1,j] = number[i,j];
            }
            else if(i > index[0] && j > index[1])
            {
                newArray[i-1,j-1] = number[i,j];
            }
        }
    }

    return newArray;
}

PrintArray(DeleteItems(numbers, FindMinValue(numbers)));