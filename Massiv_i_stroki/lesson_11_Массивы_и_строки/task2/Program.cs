// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.

System.Console.WriteLine("Введите строку");
string str = Console.ReadLine();

char[] array = new char[str.Length];


int i =0;
foreach (char item in str)
{
    array[i]= item;
    System.Console.WriteLine(array[i]);
    i++;
}