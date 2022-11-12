// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


// ! Виталий, я так и не понял , написанно что из вещественных чисел массив , а в примере не вещественные.


Console.Clear();
int[] array = {2, 6, 3, 9, 1};
int result = MaxNumbersInArray(array)-MinNumbersInArray(array);
Console.WriteLine($"разницa между максимальным и минимальным элементaми массива : {result}");
int MaxNumbersInArray(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>max)
        {
            max = arr[i];
        }
    }
    return max;
}

int MinNumbersInArray(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}