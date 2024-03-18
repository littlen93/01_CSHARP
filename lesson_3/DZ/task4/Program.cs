// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.

Console.WriteLine("Ведите число");
int num = Convert.ToInt32(Console.ReadLine());

if(num>9 && num<100)
{

int num1 = num/10;
int num2 = num%10;


Console.Write(num1+","+num2);
}



