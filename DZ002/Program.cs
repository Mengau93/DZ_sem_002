// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.Write("Введи число: ");
int N = Convert.ToInt32(Console.ReadLine());
string numbers = Convert.ToString(N);
if (numbers.Length > 2)
{
    Console.WriteLine("Третья цифра: " + numbers[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
