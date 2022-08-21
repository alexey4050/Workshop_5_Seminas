// Задача 36. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray (int [] arr)
{
int length = arr.Length;
for (int i = 0; i < length; i++)
    {
       arr[i] = new Random().Next(-10, 10);
    }
}

void PrintArray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {     
        Console.Write($"{arr[i]} ");
    }
}
int[] array = new int[4];
FillArray(array);
PrintArray(array);  
Console.WriteLine();
Console.WriteLine();

int sumNumber = 0;
for(int i = 1; i < array.Length; i+=2)
{ 
    sumNumber = sumNumber + array[i];
}

Console.Write($"Cумму элементов, стоящих на нечётных позициях = {sumNumber} ");

