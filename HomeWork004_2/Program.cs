// Задача 2
// Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

void FillArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection [index] = new Random().Next(1, 100);
        index = index + 1;
    }
} 

void PrintArra(int [] col)
{
    int count = col.Length;
    int position = 0;
    while (position<count)
    {
        Console.Write(col[position]);
        Console.Write(" ");
        position = position + 1;
    }
}

int Quanchet(int [] collection)
{
    int count = collection.Length;
    int index = 0;
    int quantity = 0;
    while (index<count)
    {
        if (collection[index] % 2 == 0)
        {
            quantity = quantity + 1;
        }
        index++;
    }
    return quantity;
}

int [] array1 = new int [10];
FillArray(array1);
PrintArra(array1);

Console.WriteLine();
int qua = Quanchet(array1);
Console.WriteLine($"количество чётных чисел в массиве = {qua}.");
