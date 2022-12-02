// Напишите программу которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3d пространстве

int XA, YA, ZA, XB, YB, ZB = 0;

int take_a_Point(string message) {
   Console.Write(message);
   int n = int.Parse(Console.ReadLine());
   return n;
}

double DistBetween(int xa, int ya, int za, int xb, int yb, int zb) {
    double d = Math.Sqrt(Math.Pow(xb -xa, 2) + Math.Pow(yb -ya, 2) + Math.Pow(zb - za, 2));
    return Math.Round(d, 2);
}

Console.WriteLine("Please enter coordinates>");
XA = take_a_Point("xa - ");
YA = take_a_Point("ya - ");
ZA = take_a_Point("za - ");
XB = take_a_Point("xb - ");
YB = take_a_Point("yb - ");
ZB = take_a_Point("zb - ");

Console.Clear();
Console.WriteLine($"A({XA}, {YA}, {ZA}); B({XB}, {YB}, {ZB}) -> {DistBetween(XA, YA, ZA, XB, YB, ZB)}");
