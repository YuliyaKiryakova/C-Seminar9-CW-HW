/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(--start, end));
}

int num = InputNum("Введите целое число: ");
Console.Write(PrintNumbers(num, 1));

// void PrintNumbers(int start, int end)
// {
//     if (start > end) return;
//     PrintNumbers(++start, end);
//     Console.Write(start-1 + " ");
// }

// int num = InputNum("Введите целое число: ");
// PrintNumbers(1, num);
