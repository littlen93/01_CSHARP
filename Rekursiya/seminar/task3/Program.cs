// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l 
// “Hello world!” => H l l w r l d

Console.WriteLine("Введите строку");
string userInput=  Console.ReadLine();

string vowels = "aeiouy";
int i =0;

 PrintStr(i,userInput);

void PrintStr(int numEl, string str)
{
    if(numEl>= str.Length)
    {
        return;
    }

    if(!vowels.Contains(str[numEl]))
    {
        Console.Write(str[numEl]+ " ");
    }

    PrintStr(numEl+1,str);
}