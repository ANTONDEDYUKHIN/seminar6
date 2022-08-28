/* Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */
Console.Clear();
Console.Write("Введите количество чисел М: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] EnterIntNum(int size)
{
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
   Console.Write($"Введите число M{i + 1}: "); 
    array[i] = Convert.ToInt32(Console.ReadLine());
}
return array;
}

int[] array1 = EnterIntNum(size);
int Count(int[] array1)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] > 0)
        count++;
    }
    return count;
}

Console.WriteLine(Count(array1));