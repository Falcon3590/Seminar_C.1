Console.WriteLine("введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());

if (firstDigit > secondDigit)
{
    int temp = firstDigit % secondDigit;
    if (temp == 0)
    {
        Console.WriteLine("кратно");
    }
    else
    {
        Console.WriteLine("не кратно, остаток " + temp);
    }
}
else
{
    int temp = secondDigit % firstDigit;
    if (temp == 0)
    {
        Console.WriteLine("кратно");
    }
    else
    {
        Console.WriteLine("не кратно, остаток " + temp);
    }
}