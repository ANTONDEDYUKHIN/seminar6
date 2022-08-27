/* Написать прогр., которая будет преобр-ть десятичное
число в двоичное 45 - 101101, 3 - 11, 4 - 10*/
Console.Clear();
Console.Write("введите целое число: ");
int number = int.Parse(Console.ReadLine());
int result = 0;
int mult = 1;
while(number > 0)
{
    result += number % 2 * mult;
    number /= 2;
    result *= 10;
}
Console.WriteLine(result);