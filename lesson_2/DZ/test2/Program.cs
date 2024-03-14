//напишите метод  который принимает на вход три числа и выдаёт максимальное из этих чисел.
int a = 10;
int b = 8;
int c = 14;

int max = a;

if (b > max)
{
    max = b;
}

if (c > max)
{
    max = c;
}
return max;