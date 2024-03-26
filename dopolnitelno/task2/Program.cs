// 1. создай программу,
//  которая будет принимать от пользователя ФИО 
//  и сохранять в разные переменные, 
//  а потом это должно красиво выводиться на консоль.


System.Console.Write("\n Введите Фамилию: ");
string surname = Console.ReadLine();
System.Console.Write("\n Введите Имя: ");
string name = Console.ReadLine();
System.Console.Write("\n Введите Отчество: ");
string name2 = Console.ReadLine();


Console.Write($"\n {surname} {name} {name2} ");

