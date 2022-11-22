// Напишите программу которая на вход принимает одно число
// (N) а на выходе показывает все числа от -N до N
Console.WriteLine("Enter num>");
int n = int.Parse(Console.ReadLine());

int minorn = -n;
while (minorn <= n) Console.Write(minorn++ + ", ");
