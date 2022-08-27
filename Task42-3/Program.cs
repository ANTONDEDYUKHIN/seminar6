/* Написать прогр., которая будет преобр-ть десятичное
число в двоичное 45 - 101101, 3 - 11, 4 - 10*/
Console.Clear();
Console.Write("введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
void DecToBin(int num)
{
    if (num == 0) return;
    DecToBin(num / 2);
    Console.Write(num % 2);
}
DecToBin(number);
