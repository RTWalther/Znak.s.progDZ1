﻿// Напишите программу, которая 
// 1.на вход принимает число (N), 
// 2.а на выходе показывает все чётные
// числа от 1 до N.
// Например:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int i = 1;
bool not = true;

Console.WriteLine("Введите число:");
num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + num);
while (i <= num)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
} if (not);
{
    Console.WriteLine("Нет чётных чисел!");
}