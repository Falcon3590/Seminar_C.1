int N = new Random().Next(1, 65536);

if (N <= 99)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    int ThirdNumber = (N / 100) % 10;
    Console.Write($"{ThirdNumber} является третей цифрой от числа {N}");
}