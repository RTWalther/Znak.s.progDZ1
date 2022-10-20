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

int max = num_A; 

if (num_B>max)
{
Console.WriteLine("Максимальное число" + num_B);
}
if (num_С>max)
{
Console.WriteLine("Максимальное число" + num_С);
}


