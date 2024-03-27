// Создание двумерного массива

int[,] matrix = new int[3, 5];
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0);i++) //цикл заполнения
{
    for (int j = 0; j < matrix.GetLength(1); j++) 
    {

        matrix[i, j] = rnd.Next(1, 11); //рандомное заполнение массива
    }
}

for (int i = 0; i < matrix.GetLength(0);i++) //цикл вывода
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        System.Console.Write($"{matrix[i, j]} "); //вывод массива 
    }
    System.Console.WriteLine(); //чтобы переносилось на новые строки
}
