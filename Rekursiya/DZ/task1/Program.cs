// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.


Console.WriteLine("Введите мин.число");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите макс.число");
int N = Convert.ToInt32(Console.ReadLine());



PrintNum(M, N);

void PrintNum(int start, int end)
{
    if (start < end)
    {

        Console.Write($"{start}, ");
        PrintNum(++start, end);
    }
    else
    {
        System.Console.Write(start);
        return;
    }

}