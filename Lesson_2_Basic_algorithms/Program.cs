// 1. генерация случайного числа из диапозона 
// 2. получить 1 цифру
// 3. 2 цифру
// 4. if
// 5.else

int N = new Random().Next(10, 99);
int firstDigit = N / 10;
int secondDigit = N % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit);
}
else
{
    Console.WriteLine(secondDigit);
}