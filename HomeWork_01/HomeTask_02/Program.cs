/*
Task_02.
Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел.
2 3 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int A = Prompt("Введите первое число > ");
int B = Prompt("Введите второе число > ");
int C = Prompt("Введите третье число > ");

int max = A;

if (A > max) max = A;
if (B > max) max = B;
if (C > max) max = C;

Console.Write("max = ");
Console.Write(max);