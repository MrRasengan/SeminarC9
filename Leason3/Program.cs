// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int N = Prompt();
Console.WriteLine(NaturalNum(N));

int Prompt()
{
    Console.WriteLine("Введите значение: ");
    int limit = int.Parse(Console.ReadLine()!);
    return limit;
}

int NaturalNum(int limit)
{
    if (limit / 10 < 1)
    {
        return limit;
    }
    else
    {
        return limit % 10 + NaturalNum(limit / 10);
    }
}