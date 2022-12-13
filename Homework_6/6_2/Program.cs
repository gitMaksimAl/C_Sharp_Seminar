// Напишите программу, которая найдет точку пересечения двух прямых,
// заданных уравнениями
// y = k1 * x + b1
// y = k2 * x + b2
// значения b1, k1, b2, k2 - задаются пользователем

double K1;
double K2;
double B1;
double B2;

double get_value(string prompt) {
    double num;
    Console.Write(prompt);
    num = double.Parse(Console.ReadLine());
    return num;
}

void get_cross(double membB1, double membK1, double membB2, double membK2) {
    double y, x;
    // fckng formula
    y = membK1 * (-(membB2 - membB1)) / (membK2 - membK1) + membB1;
    x = -(membB2 - membB1) / (membK2 - membK1);
    Console.WriteLine($" -> ({Math.Round(x, 2)}; {Math.Round(y, 2)})");
}

Console.WriteLine("Please eneter members");
K1 = get_value("K1 = ");
K2 = get_value("K2 = ");
B1 = get_value("B1 = ");
B2 = get_value("B2 = ");
get_cross(B1, K1, B2, K2);
