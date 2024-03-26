// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

Console.WriteLine("Ведите число");
int num = Convert.ToInt32(Console.ReadLine());

if(num>99 && num<1000)
{

int num1 = num/100;
int num3 = num%10;

int result = num1*10+num3;
Console.WriteLine(result);
}