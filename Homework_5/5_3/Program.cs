// Задайте массив вещественных чисел. Найдите разницу между минимальным
// и максимальным элементом массива.

// creates an array of nmemb pseudo-random integers in range[max, min]
double[] arr_of(int nmemb) {
    double[] mass = new double[nmemb];
    for (int i = 0; i < nmemb; i++) mass[i] = Math.Round(new Random(i).NextDouble() + nmemb % (i + 1), 2);
    return mass;
}

// display values of the array
void display_arr(double[] arr) {
    int last = arr.Length - 1;
    int i = 0;
    //Console.Clear();
    for (; i < last; i++) Console.Write($"{arr[i]}, ");
    Console.Write(arr[i]);
}

// return the difference between the minimal and maximal array values 
double diff_of(double[] arr) {
    double min, max;
    min  = max = arr[0];
    for (int i = 1; i < arr.Length; i++) {
        if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];
    }
    return max - min;
}

double[] array = arr_of(9);
display_arr(array);
Console.WriteLine($" -> {diff_of(array)}");
