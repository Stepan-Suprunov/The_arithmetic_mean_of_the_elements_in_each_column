// Среднее арифметическое элементов в каждом столбце


int m = 3, n = 4;
int[,] array = new int[m,n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
         array[i,j] = new Random().Next(-99,100);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("________________");

int count = 0; 
while (count < array.GetLength(1))
{
    double avg = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = count; j == count; j++)
        {
            avg += array[i,j];
        }
    }
    count ++;
    Console.Write(Math.Round(avg/array.GetLength(0),1) + "; ");
}