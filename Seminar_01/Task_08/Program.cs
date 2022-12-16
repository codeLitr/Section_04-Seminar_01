/*
Задача 8.
Вычислите факториал числа.
*/

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int value = Prompt("Введите число > ");
if(value < 0)
{
    Console.WriteLine("Число должно быть больше нуля");
}
else
{
    Console.WriteLine($"Факториал числа {value} равен -> {Factorial(value)}");
}
int Factorial(int value)
{
    int factorial = 1;
    for (int i = 1; i <= value; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}
