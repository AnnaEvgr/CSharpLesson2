/*Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int InputInt(string message)
{
    System.Console.WriteLine(message);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
int a = InputInt("Введите трехзначное число");

if (a > 99 && a < 1000)
{
    int result = ((a/10) % 10);
    System.Console.WriteLine("Вторая цифра равна " + result);
}
else
{
    System.Console.WriteLine("Число не трехзначное");
}