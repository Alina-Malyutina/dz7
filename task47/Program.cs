void FillArrayRowColByRandom(double [,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(1, 10) + new Random().NextDouble();
            table[i, j] = Math.Round(table[i, j], 2);
        }
    }
}

void PrintArray(double [,] array)
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

Console.WriteLine("This program assepts size of array and fill it by numbers like 2,33");
Console.WriteLine("Enter quantity of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter quantity of columns: ");
int m = Convert.ToInt32(Console.ReadLine());

double [,] array = new double [n,m];
FillArrayRowColByRandom(array);
PrintArray(array);
