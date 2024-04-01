// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

Console.WriteLine("Введите число");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

int[] array2 = new int[array.Length/2];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,20);
    Console.Write(array[i]+" ");
}

Console.WriteLine();

for (int i = 0; i < array2.Length; i++)   // [1 3 2 4 2 3] => [1*3, 3*2, 2*4  ]
{
    array2[i] = array[i] * array[array.Length-1-i];  // [6-1-0] [6-1-1] [6-1-2]
    Console.Write(array2[i]+ " ");
}