// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

int[] array = { 2, 3, 4, 5, 6, 8, 9, 10 };

int PrintArray(int[] array, int i = 0)
{
    if (i < array.Length)
    {
        PrintArray(array, i + 1);
        Console.Write($"{array[i]} ");

    }
    return i;
}
PrintArray(array);

