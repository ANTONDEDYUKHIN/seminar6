/*Написать программу, которая на вход принимает 
3 числа и проверяет, может ли существовать
треугольник со сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треуг. меньше сумм 2х др. сторон*/
Console.Clear();
Console.Write("введите длину стороны А: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите длину стороны B: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите длину стороны C: ");
int num3 = Convert.ToInt32(Console.ReadLine());

bool Triangle(int a, int b, int c);
{
    return (a < b + c && b < a + c && c < a + b);
}
bool result = Triangle(num1, num2, num3);
Console.WriteLine(result?"является треугольником" : "не является треугольником");