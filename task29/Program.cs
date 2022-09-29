//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.



int size = 8;
int[] array = new int[size];
FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 90);
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ",");
    System.Console.Write("]");
}
