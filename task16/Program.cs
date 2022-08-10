//Задача 16: Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число 
//квадратом другого.
//5, 25 -> да
//-4, 16 -> да
//25, 5 -> да
//8,9 -> нет

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a * a == b)
{
    Console.WriteLine("Да, первое число является квадратом второго числа");
}

else
{
    Console.WriteLine("Нет не является первое число квадратом второго");
}