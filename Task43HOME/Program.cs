/*Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
Console.Clear();

double[,] koef = new double[2, 2];// 2Д массив [строки GetLength(0), столбцы GetLength(1)]
double[] interpoint = new double[2];// 1Д массив с коорд точки пересечения

void EnterKoef()// метод ввода коэффициентов функции
{
  for (int i = 0; i < koef.GetLength(0); i++)// перебираем строки 
  {
    Console.Write($"Введите коэффициенты {i + 1} функции:\n");// приглашаем к вводу
    for (int j = 0; j < koef.GetLength(1); j++)// перебираем столбцы
    {
      if(j == 0) Console.Write($"Введите коэффициент k: ");// если номер столбца массива j = 0 выходит надпись для К
      else Console.Write($"Введите коэффициент b: ");// при номере столбца массива j > 0 выходит надпись для В
      koef[i, j] = Convert.ToInt32(Console.ReadLine());//заполнение ячеек 2Д массива через ручной ввод
    }
  }
}

double[] CalculateCoord(double[,] koef)//метод рассчета коорд точки пересеч
{
  interpoint[0] = (koef[1,1] - koef[0,1]) / (koef[0,0] - koef[1,0]);//вычисление коорд Х ч/з обращение к ячейкам массива
  interpoint[1] = interpoint[0] * koef[0,0] + koef[0,1];//формула поиска У при найденном Х
  return interpoint;
}

void PrintCoord(double[,] koef)// метод печати результата
{
    CalculateCoord(koef);
    Console.Write($"Координаты точки пересечения прямых: ({interpoint[0]}, {interpoint[1]})");
}

EnterKoef();
PrintCoord(koef);