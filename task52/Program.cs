void FillArrayRowColByRandom(int [,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int [,] array)
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

void AvgOfColumnInArray (int [,] array)
{
    double avg = 0;
    double sum = 0;
for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        avg = Math.Round(sum / array.GetLength(0), 2);
        
        Console.Write($"{avg} ");
        sum = 0;
        avg = 0;
    }
}

Console.WriteLine("This program assepts size of array, fill it and search avg of every column");
Console.WriteLine("Enter quantity of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter quantity of columns: ");
int m = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [n,m];
FillArrayRowColByRandom(array);
PrintArray(array);
AvgOfColumnInArray(array);

