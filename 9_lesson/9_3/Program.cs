// Напишите программу, которая на вход принимает два числа A и B, и возводит
// число A в целую степень числа B с помощью рекурсии.

int PowerofR(int n, int pow) {
    if (pow == 0) return 1;
    else return PowerofR(n, pow - 1) * n;
}

Console.WriteLine(PowerofR(int.Parse(Console.ReadLine()),
    int.Parse(Console.ReadLine())));
