// Напишите программу которая на вход принимает три числа и
// выдает максимальное из этих чисел

Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("b = ");
int b = int.Parse(Console.ReadLine());
Console.Write("c = ");
int c = int.Parse(Console.ReadLine());

int max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine(max);
