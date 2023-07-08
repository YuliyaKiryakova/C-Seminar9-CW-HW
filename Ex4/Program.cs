/* Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

// int InputNum(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine()!);
// }

// int StepenNumber(int start, int end)
// {
//     if (end == 0) return 1;
//     return start * StepenNumber(start, end - 1);
// }

// int numA = InputNum("Введите целое число A: ");
// int numB = InputNum("Введите целое число B: ");
// Console.WriteLine(StepenNumber(numA, numB));

// сложный вариант - учесть отрицательные степени
int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

double StepenNumber(int start, int end)
{
    if (end == 0) return 1;
    if (end > 0)
        return start * StepenNumber(start, end - 1);
    else
        return Math.Round(1 / (start * StepenNumber(start, -end - 1)), 3);
}

int numA = InputNum("Введите целое число A: ");
int numB = InputNum("Введите целое число B: ");
Console.WriteLine(StepenNumber(numA, numB));