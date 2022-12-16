/*
Task_01.
Напишите программу, которая на вход принимает два числа и выдает, какое число больше.
a = 5;	b = 7 -> max 7
a = 2;	b = 10 -> max 10
a = -9;	b = -3 -> max -3
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int firstNumb = Prompt("Введите первое число > ");
int secondNumb = Prompt("Введите второе число > ");

if (firstNumb > secondNumb)
{
	Console.Write("Наибольшее число -> ");
    Console.WriteLine(firstNumb);
    Console.Write("Наименьшее число -> ");
    Console.Write(secondNumb);
}
else
{
    Console.Write("Наименьшее число -> ");
    Console.WriteLine(firstNumb);
    Console.Write("Наибольшее число -> ");
    Console.Write(secondNumb);
}