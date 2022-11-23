void FillArrayRowColByRandom(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("This program assepts indexes of element and show element with this index in array");
Console.WriteLine("Enter  row: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter column: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[5, 5];
FillArrayRowColByRandom(array);
PrintArray(array);

if (n > array.GetLength(0) || m > array.GetLength(1))
{
    Console.WriteLine("At this position element is not exist");
}
else Console.WriteLine(array[n-1, m-1]);