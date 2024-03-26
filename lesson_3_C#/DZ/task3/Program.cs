// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

int num = new Random().Next(10,100);
Console.WriteLine(num);

int num1 =  num/10%10;
int num2 = num%10;

if(num1>num2)
{
 
   Console.WriteLine(num1);
}
else
{
    Console.WriteLine(num2);
}
