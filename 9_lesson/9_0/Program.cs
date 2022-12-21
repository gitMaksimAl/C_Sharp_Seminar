// Задайте значение N. Напишите программу, которая выведет все натуральные
// числаот 1 до N при помощи рекурсиию

void PrintNumR(int n){
    if (n == 1) Console.Write($"{n} ");
    else {
        PrintNumR(n - 1);
        Console.Write($"{n} ");
    }
}

int N = int.Parse(Console.ReadLine());
PrintNumR(N);
