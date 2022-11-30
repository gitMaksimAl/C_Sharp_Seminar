// Напишите программу которая выводит случайное число из отрезка [10, 99] и показывает наибольшую
// цифру числа
int getMax(int num) {
    Console.WriteLine(num);
    if (num / 10 > num % 10) return num / 10;
    else return num % 10;
}

Console.WriteLine(getMax(new Random().Next(10, 100)));
