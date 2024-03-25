
// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)

// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

int[] numbers = new int[10];
Random rnd = new Random();

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int R = rnd.Next(0, 100);
        array[i] = R;
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}

void ReverseArray(int[] arr)
{
    for(int i = 0; i<arr.Length/2; i++)
    {
        int temp = arr[i];
        arr[i]=arr[arr.Length-1-i];
        arr[arr.Length-1-i]=temp;
    }
}

FillArray(numbers);
PrintArray(numbers);
ReverseArray(numbers);
System.Console.WriteLine();
PrintArray(numbers);