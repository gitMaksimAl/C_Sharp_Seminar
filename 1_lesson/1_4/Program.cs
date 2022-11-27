// Напишите программу вычисления модуля числа

Console.WriteLine("Please enter num >");
int x = int.Parse(Console.ReadLine());

if (x < 0) x = -x;
Console.WriteLine(x);
