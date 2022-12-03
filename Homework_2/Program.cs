int N = new Random().Next(1, 65536);
int n = N;
if (N <= 99)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while (N > 999)
        {
            N = N / 10;
        }
    int result = N % 10;
    Console.Write($"{result} является третей цифрой от числа {n}");
}    