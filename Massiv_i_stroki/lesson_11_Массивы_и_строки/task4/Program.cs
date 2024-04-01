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
    if(vowels.Contains(userInput[i])) //contains Проверяет на наличие,есть ли символ в строке
    {
        count++;
    }
}

System.Console.WriteLine(count);