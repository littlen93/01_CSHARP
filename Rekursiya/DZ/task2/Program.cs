﻿// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n

 int Recursiya(int m, int n)
  {
        
        if (m == 0) 
        {
            return n + 1;
        } 
        else if (n == 0 && m > 0)
        {
            return Recursiya(m - 1, 1);
        } 
        else 
        {
            return Recursiya(m - 1, Recursiya(m, n-1));
        }
}
    Console.WriteLine(Recursiya(3, 2)); 

