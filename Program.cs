/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
string PrintNumbers(int n)
{
    if (n == 1) return n.ToString();

    return (n + ", " + PrintNumbers(n-1));
}

Console.WriteLine(PrintNumbers(n));
*/
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите левую границу числового промежутка: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите правую границу числового промежутка: ");
int n = Convert.ToInt32(Console.ReadLine());
int ReverseSum(int left, int right)
{
    if (left == right) return right;

    return (left + ReverseSum(left + 1, right));
}

Console.WriteLine(ReverseSum(m, n));
*/

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
*/
Console.WriteLine("Введите первое положительное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе положительное число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int Akkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}

Console.WriteLine(Akkerman(num1, num2));