//1. Показать натуральные числа от M до N, N и M заданы

Console.Write("Введите первое натуральное число: ");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите второе натуральное число: ");
int N = int.Parse(Console.ReadLine());


int Print(int N, int M)
{
    Console.WriteLine(N);
    N--;
    if (N >= M) return Print(N, M);
    else return M;
}

Print(N, M);



