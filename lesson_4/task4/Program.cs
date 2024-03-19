// Дано N гирь с разным весом в случайном
// порядке. Определить вес самой тяжелой
// гири.

int n = 10;
int[] array = { 1, 2, 5, 4, 10, 7, 8, 3, 9, 6 };
int i = 0;
int max = array[0];


while (i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.WriteLine(max);