/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}

int num = InputNum("Введите целое число: ");
Console.WriteLine(PrintNumbers(1, num));

//
// void PrintNumbers(int start, int end)
// {
//     if (start > end) return;
//     Console.Write(start + " ");//если поменять местами эту строку и нижнюю,
//     //то в обратном порядке выведутся числа!
//     PrintNumbers(start+1, end);// если написать start++, то сначала
//     //вызывается метод, потом end, потом только прибавляется единица
//     //переполнение стека и одни единицы будут!
// }

// int num = InputNum("Введите целое число: ");
// PrintNumbers(1, num);

//объяснил, почему ++ в конце не ставится - I++ постфиксный икримент, ++I - префиксный инкримент
// int end = 5;
// int start = 1;
// end = end + start++;
// Console.WriteLine(end);
// Console.WriteLine(start);

// Osman
// string PrintNumbers(int start, int end)
// {
//     if (end == 1) return String.Empty;
//     else return (PrintNumbers(start, --end) + " " + end);
// }
// int num = InputNum("Введите целое число: ");
// Console.WriteLine(PrintNumbers(1, num + 1));