// // Задать двумерный массив следующим правилом: Aₘₙ = m+n

void PrintArray (int [,] matr)
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

void FillArray (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr [i,j] = i + j;
    }
    
}
}


Console.WriteLine ("Введите количество строк в массиве: ");
int m = int.Parse (Console.ReadLine ());
Console.WriteLine ("Введите количество столбцов в массиве: ");
int n = int.Parse (Console.ReadLine ());
int [,] matrix = new int [m,n];
Console.WriteLine ();
FillArray (matrix);
PrintArray (matrix);