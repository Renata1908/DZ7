int[,] GetMatrix(int size1, int size2, int leftRange, int rightRange) // Наполнение массива случайными числами.
{
  int[,] matrix = new int[size1, size2];
  Random rand = new Random();
  for (int i = 0; i < size1; i++)
  {
    for (int j = 0; j < size2; j++)
    {
      matrix[i, j] = rand.Next(leftRange, rightRange + 1);
    }
  }
  return matrix;
}

void PrintMatrix(int[,] matrix) // Вывод массива в терминал.
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

double[] GetResultArray(int[,] matrix) // Подсчет среднеарифметического значения в каждом столбце.
{
  double[] result = new double[matrix.GetLength(1)];
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      result[j] += matrix[i, j];
    }
    result[j] = Math.Round(result[j] / matrix.GetLength(0), 1);
  }
  return result;
}


Console.WriteLine("Введите количество строк матрицы: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int[,] matr = GetMatrix(number1, number2, 0, 9);
Console.WriteLine("Рандомная матрица:");
PrintMatrix(matr);
Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ", GetResultArray(matr))}");
