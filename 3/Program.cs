﻿// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.



int[,] GetArray(int m, int n, int minValue, int maxValue)
{
   int[,] result = new int[m, n];

   for (int i = 0; i < m; i++)
   {
      for (int j = 0; j < n; j++)
      {
         result[i, j] = new Random().Next(minValue, maxValue + 1);
      }
   }
   return result;
}

void PrintArray(int[,] myArray)
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
void ElSum(int[,] myArray)
{
   for (int j = 0; j < myArray.GetLength(0); j++)

   {
      double sum = 0;
      for (int i = 0; i < myArray.GetLength(0); i++)
      {
         sum += myArray[i,j];
      }
      double afSumma = Math.Round(sum/myArray.GetLength(0),2);
      Console.Write($"{afSumma}\t");
   }
}


Console.Write("Введите кол - во строк: ");
int str = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол - во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(str, col, -10, 20);
PrintArray(array);
ElSum(array);