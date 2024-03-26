// Напиши программу, которая будет создавать записную книжку.
//  Сначала делается запрос на количество элементов, 
//  а потом пользователь должен сам заполнить необходимую информацию.
// В конце вывод всех элементов в столбик

Console.Write("Введите количество элементов: ");
int input = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите текст: ");
string text = Console.ReadLine();


for (int i = 0; i < input; i++)
{
    System.Console.WriteLine(text[i]);

}
for (int i = 0; i > input; i++)
{

    System.Console.Write("Вы привысили количество вводимых элементов");
}

