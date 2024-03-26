// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.


while (true)
{

    System.Console.Write("Введите целое число: ");
    string input = Console.ReadLine();
    if (input == "q")
    {
        System.Console.WriteLine("Программа завершена");
        break;
    }

    int num;
    if (int.TryParse(input, out num))
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }

        System.Console.WriteLine(sum);
        if (sum % 2 == 0)
        {
            System.Console.WriteLine("Программа завершена");
            break;
        }
    }
    else
    {
        System.Console.WriteLine("Введите число \nИли нажми 'q' для выхода");
    }
}