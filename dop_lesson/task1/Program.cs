// Напишите программу которая будет бесконечно
// выводить введенную пользователем строку
// наоборот
//Программа завершится если пользователь введет "exit"



while (true)
{
    System.Console.Write("\nВведите текст ");
    string text = Console.ReadLine();

       if(text == "exit")
    {
        System.Console.Write("Программа завершена");
        break;
    }
   
 
    char[] Massive = new char[text.Length];

    for(int i = 0; i < Massive.Length; i++) //заполнение массива
    {
        Massive[i]=text[i];
    }   

    for(int i = 0; i < Massive.Length; i++)
    {
       System.Console.Write(Massive[Massive.Length-1-i]); //вывод массива в обратном порядке
    }
    
 
}


