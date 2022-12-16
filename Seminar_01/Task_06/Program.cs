/*
Задача 6.
Напишите программу вычисления модуля числа.
2 -> 2
-3 -> 3
-7 -> 7
*/

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int value = Prompt("Введите число > ");
int result;
if (value < 0)
{
    result = -value;
}
else
{
    result = value;
}

Console.WriteLine($"{value} -> {result}");
