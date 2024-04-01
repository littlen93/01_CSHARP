// Задача 2: 
// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

Console.WriteLine("Ведите X");
int X = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите Y");
int Y = Convert.ToInt32(Console.ReadLine());

if (X>0 && Y >0 )
{
   Console.WriteLine("Первая четверть");
}


if (X<0 && Y>0 )
{
   Console.WriteLine("Вторая чертверть");
}


if (X<0 && Y<0 )
{
   Console.WriteLine("Третья четверть");
}



if (X>0 && Y<0 )
{
   Console.WriteLine("Четвертая четверть");
}

