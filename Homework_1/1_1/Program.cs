// Напишите программу которая на вход принимает два числа и 
// выдает какое число больше а какое меньше

Console.Write("a = ");
int x = int.Parse(Console.ReadLine());
Console.Write("b = ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("max = " + (x > y ? x : y));
