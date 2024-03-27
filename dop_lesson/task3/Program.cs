// Напиши программу, которая будет создавать записную книжку.
//  Сначала делается запрос на количество элементов, 
//  а потом пользователь должен сам заполнить необходимую информацию.
// В конце вывод всех элементов в столбик


Console.Write("Сколько контактов вы хотите внести: ");
int count = Convert.ToInt32(Console.ReadLine());
string[] book = new string[count];

for (int i = 0; i < book.Length; i++)
{
    Console.Write("Введите имя: ");
    string name = Console.ReadLine();

    Console.Write("Введите номер телефона: ");
    string tel = Console.ReadLine();


   book[i]= ($"{name} {tel}") ;
}

for (int i = 0; i < book.Length; i++)
{
    
    Console.Write("\n"+ book[i]);
}

