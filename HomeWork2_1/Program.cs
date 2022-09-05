// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int Transform(int a)
{
    return (a/10) % 10;
}
System.Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine($"{number} -> {Transform(number)}");
