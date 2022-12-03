int N = new Random().Next(100, 999);

int SecondDigit = (N / 10) % 10;

Console.Write($"{SecondDigit} является второй цифрой от числа {N}");
