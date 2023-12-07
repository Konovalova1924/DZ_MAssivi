// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

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

int Quandiap(int [] collection, int min, int max)
{
    int count = collection.Length;
    int index = 0;
    int quantity = 0;
    while (index<count)
    {
        if (collection[index]>min && collection[index]<max)
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
int qua = Quandiap(array1, 20, 90);
Console.WriteLine($"количество элементов массива, значения которых лежат в отрезке [20,90] = {qua}.");
