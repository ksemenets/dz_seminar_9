﻿// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
int Accerman(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return Accerman(m - 1, 1);
    else
      return Accerman(m - 1, Accerman(m, n - 1));
}
const int m = 2;
const int n = 0;
Console.WriteLine(Accerman(m, n));