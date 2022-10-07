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

void SearchMatrix(int[,] matrix, int line, int column) // Поиск элемента в матрице.
{
  bool flag = false;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (i == line && j == column)
      {
        Console.WriteLine($"Искомый элемент: {matrix[line, column]}");
        flag = true;
        break;
      }
    }
  }
  if (!flag)
  {
    Console.WriteLine("Такого элемента не существует!");
  }
}

Console.Write("Введите количество строк матрицы: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int[,] matr = GetMatrix(number1, number2, 0, 9);
Console.WriteLine("Рандомная матрица:");
PrintMatrix(matr);
Console.WriteLine();

Console.Write("Введите номер строки элемента матрицы: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца элемента матрицы: ");
int column = Convert.ToInt32(Console.ReadLine());

SearchMatrix(matr, line, column);