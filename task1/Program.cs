// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.Write($"Число a = {a} больше числа b = {b}");
}
if (a < b)
{
    Console.Write($"Число a = {a} меньше числа b = {b}");
}
if (a == b)
{
    Console.Write($"Число a = {a} равно числу b = {b}");
}