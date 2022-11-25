// Задача 16. Напишитк программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.Clear();

Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
 if (n * n == m || m * m == n) 
    Console.Write("YES");
 else
    Console.Write("NO");      
