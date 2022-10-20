// Напишите программу, которая 
// 1.на вход принимает два числа 
// 2. выдаёт, какое число большее, а какое меньшее.
// Например:
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.WriteLine("Введите пераое число ");
int num_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int num_B = Convert.ToInt32(Console.ReadLine());
if (num_A>num_B)
{
Console.WriteLine("Первое число " + num_A + " больше чем второе " + num_B);
}
 else
{
Console.WriteLine("Второе число " + num_B + " больше чем первое " + num_A);
}
