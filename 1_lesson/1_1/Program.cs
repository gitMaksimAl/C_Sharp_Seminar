// Task 1
// Напишите программу которая на вход принимает два числа и проверяет является
// ли первое квадратом второго

Console.WriteLine("Which num you want to ckeck");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("is power of");
int y = int.Parse(Console.ReadLine());

if (y * y == x) Console.WriteLine("YES");
else Console.WriteLine("No");

// Task 2
// Напишите программу которая будет выдавать название дня недели по
// заданному номеру

Console.WriteLine("Enter num in range 1 - 7");
x = int.Parse(Console.ReadLine());
if (x == 1) Console.WriteLine("Monday");
else if (x == 2) Console.WriteLine("Tuesday");
else if (x == 3) Console.WriteLine("Wednesday");
else if (x == 4) Console.WriteLine("Thursday");
else if (x == 5) Console.WriteLine("Friday");
else if (x == 6) Console.WriteLine("Saturday");
else if (x == 7) Console.WriteLine("Sunday");
else Console.WriteLine("WARNNG!!! Wrong num.");
