/*Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

System.Console.WriteLine("Введите номер дня недели ");
int day = Convert.ToInt32(Console.ReadLine());

if (day <6)
{
    System.Console.WriteLine($"День недели не выходной");
}
else
    System.Console.WriteLine($"День недели выходной");
    