// Задача 65: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке
//  от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"
int M = Prompt();
int N = Prompt();
if (M < N)
{
    NaturalNum(M, N);
}
int Prompt()
{
    Console.WriteLine("Введите значение: ");
    int limit = int.Parse(Console.ReadLine()!);
    return limit;
}

void NaturalNum(int M, int limit)
{
    if (M == limit)
    {
        Console.Write(limit + " ");
    }
    else
    {
        Console.Write(M + " ");
        NaturalNum(M + 1, limit);
    }
}
