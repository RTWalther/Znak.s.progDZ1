// Напишите программу, которая 
// 1. принимает на
// вход три числа 
// 2.и выдаёт максимальное из этих чисел.
// Например
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите пераое число ");
int num_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int num_B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число ");
int num_С = Convert.ToInt32(Console.ReadLine());


if (num_A>max)
{
Console.WriteLine("Максимальное число" + num_A);
}
else
{
Console.WriteLine("Максимальное число" + num_B);
}

if (num_B>num_С)
{
Console.WriteLine("Максимальное число" + num_B);
}
else
{
Console.WriteLine("Максимальное число" + num_С);
}
if (num_A>num_С)
{
Console.WriteLine("Максимальное число" + num_A);
}
else
{
Console.WriteLine("Максимальное число" + num_С);
}


