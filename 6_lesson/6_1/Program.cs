// Напишите программу, которая принимает на вход три числа и проверяет
// может ли существовать треугольник со сторонами такой длинны

void check_triangel_sides() {
    Console.WriteLine("Please enter len side a>");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter len side b>");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter len side c>");
    int c = int.Parse(Console.ReadLine());
    if (a < b + c && b < a + c && c < a + b) Console.WriteLine("Yes o.k.");
    else Console.WriteLine("Not possible.");
}

check_triangel_sides();
