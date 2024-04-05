// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5

int num= new Random().Next(1,20);
Console.WriteLine("Сген. число= "+num);
int firstEl = 1;

PrintNum(firstEl, num);

void PrintNum(int start, int end)
{
    if(start>end)
    {
        return;
    }

    Console.WriteLine(start+ " ");
    // start=start+1;
    // start++;

    PrintNum(++start, end);
}