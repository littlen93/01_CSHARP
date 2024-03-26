// Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив,состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр.



Console.Write("Введите натуральное число N: ");

int N = Convert.ToInt32(Console.ReadLine());
int nCopy = N;
int count = 0;
if (N > 0 && N < 100001)
{  
    while (nCopy > 0)
    {
        nCopy= nCopy/10;
        count++;
    }
    int[] array = new int[count];

    for(int i =0; i < array.Length; i++)
    {
        int currentDigit = N % 10; //получение последнюю цифру
        N /= 10; //отбрасываем последнюю цифру
        array[array.Length-i-1] = currentDigit;
    }
    System.Console.Write('[');
    for(int i =0; i < array.Length-1; i++)
    {
    System.Console.Write($"{array[i]} ");
    }
    System.Console.Write($"{array[array.Length-1]}]");
}
else
{
    System.Console.Write("Диапозон вводимого числа от 1 до 100 000");
}

