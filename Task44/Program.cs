/* Написать прогр., которая будетвыводить первые Н чисел фибоначчи. 
Первые 2 числа Фибоначчи 0 и 1. 5 - 0 1 1 2 3, 3 - 0 1 1, 7 - 0 1 1 2 3 5 8*/
Console.Clear();
Console.Write("введите целое положительное число: ");
int number = int.Parse(Console.ReadLine());

void ShowFibonacci(int num)
{
    int num1 = 0;
    int num2 = 1;
    Console.Write(num1+" "+num2+" ");
    for(int i = 2; i < num; i++)
    {
        int temp = num1 + num2;
        num1 = num2;
        num2 = temp;
        Console.Write(temp+" ");
    }
    Console.WriteLine();
}
ShowFibonacci(number);