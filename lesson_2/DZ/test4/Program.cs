//напишите метод которая на вход принимает число (number), 
//а на выходе выводит все чётные числа от 1 до number (включительно), 
//после каждого числа должен быть знак пробела.

// Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());
int startNumber = 1;
int number = 5;

while (startNumber<=number)
    startNumber++;
    if (startNumber % 2 == 1)
        Console.ReadLine(startNumber);