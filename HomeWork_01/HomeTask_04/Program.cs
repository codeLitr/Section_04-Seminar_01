/*
Task_04.
Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все четные числа от 1 до N.
5 -> 2, 4
8-> 2, 4, 6, 8
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int value = Prompt("Введите число > ");

for (int index = 1; index <= value; index++)
    if (index % 2 == 0)
    {
        Console.WriteLine($" {index},");
    }

    /*
    Предложение преподавателя:
    for (int index = 2; index <= value; index+=2)
    {
        Console.WriteLine($" {index},");
    }
    */