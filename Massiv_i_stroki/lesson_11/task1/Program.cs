// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива. 

char[] array = new char[] {'l','7','u','9','1','0'};

string str = "";

for (int i = 0; i < array.Length; i++)
{
    str = str+ array[i];
}
Console.WriteLine(str);