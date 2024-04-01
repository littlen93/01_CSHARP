// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да 


Console.WriteLine("Введите число которое нужно обнаружить");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[9];
string isFind= "Нет";

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,20);
    Console.Write(array[i]+" ");

    if(array[i] == num)
    {
        isFind="Да";
    }
}

Console.WriteLine(isFind);

