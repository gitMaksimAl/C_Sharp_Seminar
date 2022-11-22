// Напишите программу которая на вход принимает число N а на выходе
// показывает все четные числа от 1 до N
Console.WriteLine("Please enter positive num >");
int x = int.Parse(Console.ReadLine());
int y = 2;

if (x <= 0) Console.WriteLine($"{x} is not positive num");
else {
    while (y < x) {
        Console.Write(y + ", ");
        y += 2;
    }
}
