// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

Console.Write("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if(num>99 || num<1000)  //Чтобы несколько условий в if работали используем &&-и   ||- или
{
    int FirstEl = num/100; //456/100=4
    int endEl = num%10; // 456%10=6

    int result = FirstEl+endEl;
    Console.Write(result);
}
else
{
    Console.WriteLine("Число не подходит");
}