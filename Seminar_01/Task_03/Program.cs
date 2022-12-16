/*
Задача 3.
Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница 
*/

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

string[] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

int value = Prompt("Введите день недели > ");
if(value < 0 || value > 7) // || - Означает "или", т.е. если вводимое пользователем значение будет меньше 0 или больше 7, то выдаст соответствующее сообщение
{
    Console.WriteLine("Нет такого дня недели");
} 
else
{
int daysValue = value - 1;
Console.WriteLine($"{value} -> {days[daysValue]}");
}
