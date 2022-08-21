// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2 

void FillArray (int [] arr)
{
int length = arr.Length;
for (int i = 0; i < length; i++)
    {
       arr[i] = new Random().Next(100, 1000);
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

int[] array = new int[5];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine();

int count = 0;
int length = array.Length;

for (int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 1) continue;
    { 
    count++;
    }
}
Console.Write($"Количество чётных чисел в массиве = {count} " );
