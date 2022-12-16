/*
Task_03.
Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int A = Prompt("Введите число для проверки > ");

if(A % 2 == 0)
{
    Console.WriteLine("Введенное число четное");
}

else
{
    Console.WriteLine("Введенное число нечетное");
}