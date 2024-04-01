// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

System.Console.WriteLine("Введите количество строк");
int rows= Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов");
int columns= Convert.ToInt32(Console.ReadLine());

int[,] array  = new int[rows,columns];
double[] array2  = new double[array.GetLength(1)];

FillingArray();
PrintArray();

GetSumInArray();
PrintOneArray();

void FillingArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j]= new Random().Next(1,10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

void GetSumInArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum=0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        array2[i] = sum/array.GetLength(1);
    }
}

void PrintOneArray()
{
    System.Console.WriteLine();
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write(array2[i]+ " ");
    }
}