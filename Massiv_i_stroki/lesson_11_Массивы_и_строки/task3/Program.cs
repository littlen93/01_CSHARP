// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

System.Console.WriteLine("Введите строку");
string userInput = Console.ReadLine();

string vowels= "aeiouy";
int count =0;

for (int i = 0; i < userInput.Length; i++)
{
    for (int j = 0; j < vowels.Length; j++)
    {
        if(userInput[i]== vowels[j])
        {
            count++;
            break;
        }
    }
}

System.Console.WriteLine(count);