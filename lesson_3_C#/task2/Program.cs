// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
int num = new Random().Next(100,1000);
Console.WriteLine(num);

int num2 =  num/10%10;
int num3 = num%10;

int result =1;

while(num3>0)
{
    result = result*num2;
    num3 = num3-1;
}

Console.WriteLine(result);



