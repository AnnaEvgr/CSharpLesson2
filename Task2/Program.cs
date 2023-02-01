/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

System.Console.WriteLine("Введите любое число ");
string valuestring = Console.ReadLine();
char[] ch = valuestring.ToCharArray();
if (ch.Length >= 3)
{
    System.Console.WriteLine($"Третья цифра {ch[2]}");
}
else
{
    System.Console.WriteLine($"Третьей цифры нет");
}