/* Написать прогр., которая будет преобр-ть десятичное
число в двоичное 45 - 101101, 3 - 11, 4 - 10*/
Console.Clear();
Console.Write("введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = default;
while(number > 0)
{
    result += number % 2;
    number /= 2;
    result *= 10;
}
Console.WriteLine(result / 10);