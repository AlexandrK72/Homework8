using System;

public class Answer
{
    public static void PrintMatrix(int[,] matrix)
    {
        // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)

        {
            Console.Write("");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine("");
        }

    }


    public static void SortRowsDescending(int[,] matrix)
    {
        // Введите свое решение ниже
        int temp = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int n = 0; n < matrix.GetLength(1); n++)
                {

                    if (matrix[i, j] > matrix[i, n])
                    {
                        temp = matrix[i, j];
                        matrix[i, j] = matrix[i, n];
                        matrix[i,n] = temp;

                    }
                }

            }


        }
    }

        // Не удаляйте и не меняйте метод Main! 
        public static void Main(string[] args)
        {
            int[,] matrix;
            if (args.Length == 0)
            {
                // Если аргументы не переданы, используем матрицу по умолчанию
                matrix = new int[,] {
                {5, 2, 9},
                {8, 1, 4},
                {6, 7, 3}
            };
            }
            else
            {
                // Иначе, парсим аргументы в двумерный массив
                string[] rows = args[0].Split(';');
                matrix = new int[rows.Length, rows[0].Split(',').Length];
                for (int i = 0; i < rows.Length; i++)
                {
                    string[] elements = rows[i].Split(',');
                    if (elements.Length != matrix.GetLength(1))
                    {
                        Console.WriteLine($"Ошибка: Неправильное количество элементов в строке {i + 1}.");
                        return;
                    }
                    for (int j = 0; j < elements.Length; j++)
                    {
                        if (int.TryParse(elements[j], out int number))
                        {
                            matrix[i, j] = number;
                        }
                        else
                        {
                            Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                            return;
                        }
                    }
                }
            }

            Console.WriteLine("Исходная матрица:");
            PrintMatrix(matrix);

            SortRowsDescending(matrix);

            Console.WriteLine("\nМатрица с упорядоченными по убыванию строками:");
            PrintMatrix(matrix);
        }
    }