// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет: 
// "Позиция по рядам выходит за пределы массива" или
// "Позиция по колонкам выходит за пределы массива"

// Позиции в массиве считать от единицы.

int[,] numbers = new int[,]
{
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};

Printnumbers();
System.Console.WriteLine("Введите x (строку)");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите y (столбец)");
int y = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();





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


int GetNumInNumbers(int [,] numbers ,int x, int y)
{
    int result = 0;
    
            if (x <= numbers.GetLength(0) && y <= numbers.GetLength(1))
            {
                result = numbers[x-1,y-1];
            }
    return result;
}
void PrintMessage(int[,] array, int x, int y)
{

    if (x > array.GetLength(0))
    {
        System.Console.Write("Позиция по строкам выходит за пределы массива");
    }
    
    else if (y > array.GetLength(1))
    {
        System.Console.Write("\nПозиция по рядам выходит за пределы массива");
    }
    else 
    {
    System.Console.WriteLine(GetNumInNumbers(numbers ,x ,y));
    }
}

PrintMessage(numbers, x, y);




