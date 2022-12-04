// Напишите цикл, который принимает на входдва числа(a, b)
// и возводит число a в натуральную степень b

int getNum(string message) {
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}


// function raise num a(integer) to power b(integer), does not handle stack overflow
void power_of(int a, int b) {
    int pow = 1;
    Console.Write($"{a}, {b} -> ");
    if (b < 0 && a != 0) {
        b = -b;
        Console.Write("1/");
    }
    if (b == 0 && a > 0) pow = 1;
    else if (a == 0) {
        if (b == 0) pow = 1;
        else pow = 0;
    } else for (int i = 0; i < b; i++) pow *= a;
    Console.WriteLine(pow);
}

power_of(getNum("Enter number a>"), getNum("Enter number b>"));
