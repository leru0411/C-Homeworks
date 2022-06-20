// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число больше нуля: ");
int num = int.Parse(Console.ReadLine());
int count = 2;
Console.Write("1"+" ");
while (count <= num)
{
    Console.Write(count+" ");
    count += 2;
}