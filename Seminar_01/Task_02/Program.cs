﻿/*
Задача 2.
Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 5; b = 25 -> да
a = 2; b = 10 -> нет
a = 9; b = -3 -> нет
a = -3; b = 9 -> да
*/

int Prompt(string message)
{
    Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int firstValue = Prompt("Введите первое число > ");
int secondValue = Prompt("Введите второе число > ");
if (firstValue * firstValue == secondValue)
{
    Console.WriteLine("-> Да");
}
else
{
    Console.WriteLine("-> Нет");
}