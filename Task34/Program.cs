// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
Console.Clear();
Random random = new Random();

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i]= random.Next(100, 1000);
}
foreach (int item in array)
{
    Console.Write($"{item} ");
}
int result = CountEvenNumbersInArray(array);

Console.WriteLine();
Console.Write($" колличество четных чисел в массиве: {result}");
    


int CountEvenNumbersInArray(int[] arr)
{
    int count = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j]%2 == 0)
        {
            count ++;
        }
    }
    return count;
}