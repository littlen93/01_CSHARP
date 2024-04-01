// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.

System.Console.WriteLine("Введите строку");
string text = Console.ReadLine();
string reverse = string.Join("", text.Reverse());

if(text == reverse)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}