// Напишите программу которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

int ReadPoint(string message) {
    Console.WriteLine(message);
    int n = int.Parse(Console.ReadLine());
    return n;
}

double getDistance(int ax, int ay, int bx, int by) {
    double n;
    n = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
    return Math.Round(n, 2);
}

int ax = ReadPoint("Enter aX>");
int ay = ReadPoint("Enter aY>");
int bx = ReadPoint("Enter bX>");
int by = ReadPoint("Enter bY>");

Console.WriteLine(getDistance(ax, ay, bx, by));
