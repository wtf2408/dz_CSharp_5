// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6]-> 0


Console.Clear();
int[] array = new int[4];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(1, 100);
}

Console.Write("[ ");
foreach (int item in array)
{
    Console.Write($"{item} ");
}
Console.Write("]");
Console.Write(" -> ");
Console.Write(SummOddNumbersInArray(array));

int SummOddNumbersInArray(int[] arr)
{
    int sum = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (j%2 != 0 && j != 0)
        {
            sum +=arr[j];
        }
    }
    return sum;
}
