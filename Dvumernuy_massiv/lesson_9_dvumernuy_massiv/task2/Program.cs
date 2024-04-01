//Помещение двумерного массива в функцию
int[,] CreateMatrix(int rowsCount, int columnsCount)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void ShoyMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) //цикл вывода
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            System.Console.Write($"{matrix[i, j]} "); //вывод массива 
        }
        System.Console.WriteLine(); //чтобы переносилось на новые строки
    }
}
int[,] matrix = CreateMatrix(4,5);
ShoyMatrix(matrix);