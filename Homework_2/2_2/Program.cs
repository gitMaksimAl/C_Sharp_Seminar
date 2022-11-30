// Напишите программу которая выводит случайное трехзначное число и удаляет
// вторую цифру

// function get pseudo-random three-digit number
int getThreeDig() {
        int x = new Random().Next(100, 1000);
        Console.Write($"{x} => ");
        return x;
}

// function return converted three-digit number to two-digit(without second digit)
int getTwoDig(int num) {
    int ret_val = num / 100;
    ret_val *= 10;
    ret_val += num % 10;
    return ret_val;
}

// function display first and last digit of three-digit number
void pushTwoDig(int n) {
        Console.WriteLine($"{n / 100}{n % 10} // 1st method");
}

pushTwoDig(getThreeDig());
Console.WriteLine($"{getTwoDig(getThreeDig())} // 2nd method");
