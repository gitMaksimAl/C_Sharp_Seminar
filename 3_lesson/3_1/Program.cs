// Напишите программу которая по заданному номеру четверти показывает
// диапазон возможных координат точек в этой четверти (x, y).

void getRange(string quart) {
    if (quart == "I") Console.WriteLine("x > 0 and y > 0");
    else if (quart == "II") Console.WriteLine("x < 0 and y > 0");
    else if (quart == "III") Console.WriteLine("x < 0 and y < 0");
    else if (quart == "IV") Console.WriteLine("x > 0 and y < 0");
    else Console.WriteLine("not possible");
}

Console.WriteLine("Please enter the quarte [I - IV]>");
getRange(Console.ReadLine());
