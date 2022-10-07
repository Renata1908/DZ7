double[,] GetMatrix(int size1, int size2, int leftRange = -10, int rightRange = 10) // Наполнение массива случайными вещественными числами.
{
  double[,] matrix = new double[size1, size2];
  Random rand = new Random();
  for (int i = 0; i < size1; i++)
  {
    for (int j = 0; j < size2; j++)
    {
      // matrix[i, j] = Math.Round(rand.NextDouble() * 20 - 10, 1);
      matrix[i, j] = Math.Round(rand.NextDouble() * (rightRange - leftRange) + leftRange, 1);
    }
  }
  return matrix;
}

void PrintMatrix(double[,] matrix) // Вывод массива в терминал.
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
  }
}


Console.WriteLine("Введите количество строк матрицы: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы: ");
int number2 = Convert.ToInt32(Console.ReadLine());

double[,] matr = GetMatrix(number1, number2);
Console.WriteLine("Рандомная матрица вещественных чисел:");
PrintMatrix(matr);