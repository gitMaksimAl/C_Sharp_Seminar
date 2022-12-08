// Задайте одномерный массив, заполненый случайными числами.
// Найдите сумму элементов, стоящих на не четных позициях.


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

// return the sum of odd array members 
int fold_through_one(int[] arr) {
    int sum = 0;
    for (int i = 0; i < arr.Length; i += 2) sum += arr[i];
    return sum;
}

int[] array = arr_of(9, -9, 9);
display_arr(array);
Console.WriteLine($" -> {fold_through_one(array)}");
