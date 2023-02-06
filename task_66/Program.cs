// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSumma(int m, int n)
{   
    int summa = n;
    if(n < m) return 0;
    return summa += GetSumma(m, n - 1);
    
}
const int m = 1;
const int n = 200;
Console.WriteLine(GetSumma(m, n));