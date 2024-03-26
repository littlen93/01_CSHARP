// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

int num1 = new Random().Next(10,100);
Console.WriteLine(num1);

int num2 = new Random().Next(1,10);
Console.WriteLine(num2);

if(num1%num2 ==0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет,"+ num1%num2);
}