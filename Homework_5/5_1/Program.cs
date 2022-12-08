// Задайте массив, заполненый случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.

// creates an array of nmemb pseudo-random integers in range[max, min]
int[] arr_of(int nmemb, int min, int max) {
    int[] mass = new int[nmemb];
    for (int i = 0; i < nmemb; i++) mass[i] = new Random().Next(min, max);
    return mass;
}

// display values of the array
void display_arr(int[] arr) {
    int last = arr.Length - 1;
    int i = 0;
    //Console.Clear();
    for (; i < last; i++) Console.Write($"{arr[i]}, ");
    Console.Write(arr[i]);
}

// return count of even nums in array
int EvenCount(int[] arr) {
    int count = arr.Length;
    for (int i = 0; i < arr.Length; i++) count -= arr[i] % 2;
    return count;
}

int[] array = arr_of(9, 100, 1000);
display_arr(array);
Console.WriteLine($" -> {EvenCount(array)}");
