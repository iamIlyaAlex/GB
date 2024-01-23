using static System.Console;
// Двумерный массив в виде функции
// 1 Что будет делать функция? - Функция будет выделять память под массив некоторого размера и заполнять его случайными целыми числами.
// 2 Какие данные ей понадобятся для этого? - Для выделения участка памяти нам нужно обязательно знать его размер.
// 2 То есть размеры матрицы в виде числа строк и столбцов можно передать в качестве параметров.
// 3 Что будет возвращать функция? - Функция имеет определенный результат работы – двумерный массив.
// 3 Его можно вернуть в качестве возвращаемого значения.

// int[,] CreateMatrix(int rowsCount, int columnsCount) // функция, которая возвращает двумерный массив целых чисел мatrix
// // назовем первый параметр rowsCount (от англ. число строк), второй параметр – ColumnsCount (числостолбцов).
// {
//     int[,] matrix = new int[rowsCount, columnsCount];

//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(1, 11);
//         }
//     }
//     return matrix;
// }

// void ShowMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] matrix = CreateMatrix(4, 5);
// ShowMatrix(matrix);


// Задача 2
// Назовём число «интересным» если его сумма цифр чётная.
// Создать двумерный массив, состоящий из целых чисел. Вывести на экран «интересные» элементы массива

// int[,] CreateMatrix(int rowsCount, int columnsCount)
// {
//     // Функция создания двумерного массива:
//     int[,] matrix = new int[rowsCount, columnsCount];

//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(1, 1000);
//         }
//     }
//     return matrix;
// }

// // вывод на консоль массива:
// void ShowMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Write($"{matrix[i, j]} ");
//         }
//         WriteLine();
//     }
// }

// цикл, который будет осуществлять перебор элементов массива:
int[,] matrix = CreateMatrix(3, 4);
ShowMatrix(matrix);
foreach (int e in matrix)
{
    if (IsIntresting(e) == true)
        Write($"{e} ");
}

// Реализация для функции IsInteresting.
// Возвращать она будет значение типа bool, на вход принимать один параметр – целое число, которое и будет проверяться:
bool IsIntresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigits % 2 == 0) // Вычисление суммы цифр числа
    {
        return true;
    }
    return false;
}

// написать функцию GetSumOfDigits:
int GetSumOfDigits(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum += value % 10; // Проверка суммы чисел на чётность
        value = value / 10;
    }
    return sum;
}