// Задача 38. Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray (double [] arr)
{
int length = arr.Length;
for (int i = 0; i < length; i++)
    {
       arr[i] = new Random().Next(0, 100);
    }
}

void PrintArray (double [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {     
        Console.Write($"{arr[i]} ");
    }
}
double[] array = new double[5];
FillArray(array);
PrintArray(array);  
Console.WriteLine();

double minNumber = array[0];
double maxNumber = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (maxNumber < array[i])
    {
        maxNumber = array[i];
    }
    if (minNumber > array[i])
    {
        minNumber = array[i];
    }
}
double difference = maxNumber - minNumber;

Console.WriteLine($"Разница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {difference}");    



