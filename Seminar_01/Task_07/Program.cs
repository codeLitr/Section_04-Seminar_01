/*
Задача 7.
Напишите программу, которая принимает на вход значения и показывает его обратное значение.
1 -> 1
2 -> 0,5
0,25 -> 4
*/

double Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    double value = double.Parse(strValue);
    return value;
}

double value = Prompt("Введите число > ");

if (value == 0)
{
    Console.WriteLine("Нельзя делить на ноль");
}
else
{
    double result = 1 / value;
    Console.WriteLine($"{value} -> {result}");
}
