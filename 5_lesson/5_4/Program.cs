// Найдите произведение пар чисел в одномерном массиве.
// Парой считается первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

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

// return new massive from the product of pairs of another massive
int[] PairsFrom(int[] arr) {
    int len1 = arr.Length;
    int len2 = len1 / 2 + len1 % 2;
    int[] retArr = new int[len2];
    int i = 0;
    for (; i < len1 / 2; i++) {
        retArr[i] = arr[i] * arr[(len1 - 1) - i];
    }
    if (len2 % 2 != 0) retArr[i] = arr[i];
    return retArr;
}

int[] array = arr_of(8, 1, 18);
display_arr(array);
display_arr(PairsFrom(array));
