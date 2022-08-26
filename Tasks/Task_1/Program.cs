// Показать двумерный массив размером m×n заполненный вещественными числами

void PrintArray (double [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write ($"{matr [i, j]} ");
    }
    Console.WriteLine ();
}
}

void FillArray (double [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr [i,j] = new Random().NextDouble () * 10;
    }
    
}
}


Console.WriteLine ("Введите количество строк в массиве: ");
int m = int.Parse (Console.ReadLine ());
Console.WriteLine ("Введите количество столбцов в массиве: ");
int n = int.Parse (Console.ReadLine ());
double [,] matrix = new double [m,n];
Console.WriteLine ();
FillArray (matrix);
PrintArray (matrix);
