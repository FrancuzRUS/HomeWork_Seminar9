//1. Показать натуральные числа от M до N, N и M заданы

Console.Write("Введите первое натуральное число: ");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите второе натуральное число: ");
int N = int.Parse(Console.ReadLine());

if (M < N)
{
    for (int i = M; i <= N; i++)
    {
        Console.WriteLine($"{i}");
    }
}
else
{
    for (int i = M; i >= N; i--)
    {
        Console.WriteLine($"{i}");
    }
}
