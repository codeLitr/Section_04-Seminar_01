/*
Задача 3.
Напишите программу вычисления функции куба: 
x = f(a) 
*/

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int value = Prompt("Введите число > ");
Console.WriteLine(value * value * value);
