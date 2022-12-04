// Напишите программу которая принимает на вход число N и
// выдает произведение чисел от 1 до N

int multNums(int n) {
    int ret_val = 1;
    for (int i = 1; i <= n; ret_val *= i++) continue;
    return ret_val;
}

Console.WriteLine(multNums(int.Parse(Console.ReadLine())));
