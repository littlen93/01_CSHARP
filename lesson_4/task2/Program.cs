﻿// требуется заполнить массив целыми
// числами от 1 до N, где N – некоторое натуральное число 
// и вывести его на экран.

int n = 10;
int[] arr = new int[n];
int i = 0;

while (i < arr.Length)
{
    arr[i] = i + 1;
    // Console.Write(arr[i]);
    // Console.Write(' ');
    Console.Write($"{arr[i]} ");
    i = i + 1;
}