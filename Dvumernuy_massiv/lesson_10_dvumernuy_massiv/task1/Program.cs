﻿// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3
//  4 3 4 1 =>
//  2 9 5 4
// Обсудить этапы решения задачи
// Оформить этапы в виде функций
// 4 3 16 3
// 4 3 4 1
// 4 9 25 4

int[,] array  = new int[5,7];

FillingArray();
PrintArray();
ChangeArray();
Console.WriteLine();

PrintArray();

void FillingArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j]= new Random().Next(1,10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

void ChangeArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i%2==0 && j%2==0)
            {
                array[i,j]= array[i,j]* array[i,j];
            }
        }
    }
}