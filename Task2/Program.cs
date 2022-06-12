// 2. Найти сумму элементов от M до N, N и M заданы

Console.Write("Введите первое число: ");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int N = int.Parse(Console.ReadLine());

int SUM(int A, int B)
{
    if (A == B) return B;
    else if (A < B) return B + SUM(A, (B-1));
    else return A + SUM((A-1), B);
}
Console.WriteLine(SUM(M, N));

