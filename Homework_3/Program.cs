//Задача 3: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N % 23 == 0)
{
    if (N % 7 == 0)
    {
        Console.WriteLine($"Число {N} кратно 7 и 23");
    }
    else
    {
        Console.WriteLine($"Число {N} некратно 7 и 23");
    }
}
else
{
   
    Console.WriteLine($"Число {N} некратно 7 и 23");
    
}
