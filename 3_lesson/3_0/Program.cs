// Напишите программу которая принимает на вход координаты точки (X, Y)
// причем X != 0, Y != 0 и выдает номер четверти плоскости в которой находится.

void Quarters(int x, int y) {
    if (x > 0 && y > 0) Console.WriteLine("I");
    else if (x < 0 && y > 0) Console.WriteLine("II");
    else if (x < 0 && y < 0) Console.WriteLine("III");
    else if (x > 0 && y < 0) Console.WriteLine("IV");
    else Console.WriteLine("on the axis");
}

Quarters(0, 1);
Quarters(2, 1);
Quarters(-1, 3);
Quarters(-2, -5);
Quarters(3, -4);
