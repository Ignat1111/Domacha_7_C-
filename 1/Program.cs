// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
Console.Clear();
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
   double[,] result = new double[m, n];

   for (int i = 0; i < m; i++)
   {
      for (int j = 0; j < n; j++)
      
         result[i, j] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 2);
   }
   return result;
}
void PrintArray(double[,] myArray)
{
   for (int i = 0; i < myArray.GetLength(0); i++)
   {
      for (int j = 0; j < myArray.GetLength(1); j++)
      {
         Console.Write($"{myArray[i, j]}\t  ");
      }
      Console.WriteLine();
   }
}

Console.Write("Ввидите кол - во строк: ");
int str = int.Parse(Console.ReadLine()!);
Console.Write("Ввидите кол - во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
double[,] array = GetArray(str, col, -10, 20);
PrintArray(array);