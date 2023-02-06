// Задача 64: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"


void PrintNaturalNumber(int n, int m)
{
    if(n < m) return;
    PrintNaturalNumber(n - 1, m);
    Console.Write ($"{n}, ");
}
int m = 5;
int n = 15;
PrintNaturalNumber(n, m);
