﻿int n = 10;
int[] array = { 1, 2, 5, 4, 10, 7, 8, 3, 9, 6 };
int i = 0;
int max = array[0];

//WHILE

while (i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.WriteLine(max);

//FOR

max = array [0];
for(int j = 0; j<n; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
    
}
Console.WriteLine(max);

//FOREACH

max = array [0];
foreach(int e in array)
{
     if (e > max)
    {
        max = e;
    }
}
Console.WriteLine(max);