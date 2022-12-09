// Задайте одномерный массив из 123 случайных чисел. Найдите количество
// элементов массива, значения которых лежат в отрезке[10, 99]

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
    Console.WriteLine(arr[i]);
}

int CountR(int[] arr) {
    int len = arr.Length;
    int count = 0;
    for (int i = 0; i < len; i++) {
        if (arr[i] > 9 && arr[i] < 100) count++;
    }
    return count;
}
int[] array = arr_of(123, 1, 1000);
display_arr(array);
Console.WriteLine($"{CountR(array)} nums in array in range[10, 99].");
