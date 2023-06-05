// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int A = Prompt();
int B = Prompt();
Console.WriteLine(NaturalNum(A, 1, B));

int Prompt()
{
    Console.WriteLine("Введите значение: ");
    int limit = int.Parse(Console.ReadLine()!);
    return limit;
}

int NaturalNum(int limit, int B1, int B2)
{
    if (B1 == B2)
    {
        return limit;
    }
    else
    {
        return limit * NaturalNum(limit, B1 + 1, B2);

    }
}