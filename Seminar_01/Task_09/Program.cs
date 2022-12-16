/*
Задача 9.
Вычислить числа Фиббоначи.
*/

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Данное значение невозможно преобразовать в целое число");
}
int value = Prompt("Введите число > ");
if (value < 0)
{
    Console.WriteLine("Число должно быть с нуля");
}
else
{
    Console.WriteLine($"Номер числа последовательности Фиббоначи {value} Значение числа -> {Fibbonachi(value)}");
}

int Fibbonachi(int value)
{
    int fibbonachi = 0;
    int tempVar1 = 0;
    int tempVar2 = 1;
    for (int i = 0; i <= value; i++)
    {
        fibbonachi = tempVar1 + tempVar2;
        tempVar1 = tempVar2;
        tempVar2 = fibbonachi;
    }
    return tempVar1;
}
