// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

Console.WriteLine("Введите число");
int userNum = Convert.ToInt32(Console.ReadLine());  // 123

int GetSumNum(int num)
{
    if(num<=0)
    {
        return 0;
    }

    return num % 10 + GetSumNum(num/10);  //   123/10 = 12 /10 = 1
}
System.Console.WriteLine(GetSumNum(userNum));