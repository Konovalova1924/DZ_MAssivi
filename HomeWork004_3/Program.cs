// Задача 3
// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection [index] = new Random().NextDouble()*100.0 - 50.0 + 0.0001;
        
        index = index + 1;
    }
} 

void PrintArra(double [] col)
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

double MinMaxdif(double [] collection)
{
    int count = collection.Length;
    int index = 0;
    double diff = 0;
    double min = collection[0];
    double max = collection[0];
    while (index<count)
    {
        if (collection[index] < min)
        {
            min = collection[index];
        }
        if (collection[index] > max)
        {
            max = collection[index];
        }
        index++;
    }
    diff = max - min;
    return diff;
}

double [] array1 = new double [10];
FillArray(array1);
PrintArra(array1);

Console.WriteLine();
double qua = MinMaxdif(array1);
Console.WriteLine($"разницу между максимальным и минимальным элементами массива = {qua}.");
