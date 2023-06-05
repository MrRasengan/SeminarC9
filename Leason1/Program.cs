// Задача 63: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке
//  от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int N = Prompt();
NaturalNum(1, N);
int Prompt()
{
    Console.WriteLine("Введите значение: ");
    int limit = int.Parse(Console.ReadLine()!);
    return limit;
}

void NaturalNum(int count, int limit)
{
    if (count == limit)
    {
        Console.Write(limit + " " );
    }
    else
    {
        Console.Write(count + " ");
        NaturalNum(count + 1, limit);
    }
}
