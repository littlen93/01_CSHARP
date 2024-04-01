// Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Ведите число");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = 7;
int num2 = 23;

if(num%num1 ==0 && num%num2==0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}