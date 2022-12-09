// Задайте массив из 12ти элементов, заполненый случайными числами [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

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
    Console.Clear();
    for (; i < last; i++) Console.Write($"{arr[i]}, ");
    Console.WriteLine(arr[i]);
}

// display sum of positive nambers and sum of negative numbers of array
void display_sums(int[] arr) {
    int pos, neg;
    pos = neg = 0;
    int len = arr.Length;
    for (int i = 0; i < len; i++) {
        if (arr[i] > 0) pos += arr[i];
        else neg += arr[i];
    }
    Console.WriteLine($"sum of positive numbers = {pos}\nsum of negative numbers = {neg}");
}

int[] m = arr_of(12, -9, 9);
display_arr(m);
display_sums(m);
