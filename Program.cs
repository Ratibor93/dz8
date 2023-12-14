// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// int ReadInt(string str)
// {
// System.Console.Write(str);
// return Convert.ToInt32(Console.ReadLine());
// }

// void PrintNumbers(int M, int N)
// {
// if(M > N) return;
// Console.Write(M + " ");
// PrintNumbers(M + 1, N);
// }

// // ----------------------
// int M = ReadInt("Введите значени M больше: ");
// int N = ReadInt("Введите значени N больше 0: ");

// PrintNumbers(M, N);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int n = 3;
// int m = 2;
// int result = AckermannFunction(n, m);

// Console.WriteLine($"A({n}, {m}) = {result}");
    

// static int AckermannFunction(int n, int m)
//     {
//         if (n == 0)
//         {
//             return m + 1;
//         }
//         else if (m == 0)
//         {
//             return AckermannFunction(n - 1, 1);
//         }
//         else
//         {
//             return AckermannFunction(n - 1, AckermannFunction(n, m - 1));
//         }
//     }


// Задача 3: Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.

    
// Произвольный массив
int[] array = { 1, 2, 3, 4, 5 };

// Вывод элементов массива, начиная с конца
 PrintArrayReversed(array, array.Length - 1);
    

static void PrintArrayReversed(int[] array, int index)
{
    if (index >= 0)
    {
        Console.Write($"{array[index]} "); // Вывод текущего элемента
// Рекурсивный вызов для следующего элемента в обратном порядке
        PrintArrayReversed(array, index - 1);
    }
}




