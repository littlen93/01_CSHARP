//напишите метод которая на вход принимает число (number), 
//а на выходе выводит все чётные числа от 1 до number (включительно), 
//после каждого числа должен быть знак пробела.


int number = Convert.ToInt32(Console.ReadLine());
int startNumber = 1;
int number = 5;

while (startNumber <= number)
{
    if (startNumber % 2 == 0)
    {
        Console.Write(startNumber + " ");
    }
    startNumber++;
}
