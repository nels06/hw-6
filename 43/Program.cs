// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите k1: ");
bool isNumK1 = double.TryParse(Console.ReadLine(), out double k1);
Console.Write("Введите b1: ");
bool isNumB1 = double.TryParse(Console.ReadLine(), out double b1);
Console.Write("Введите k2: ");
bool isNumK2 = double.TryParse(Console.ReadLine(), out double k2);
Console.Write("Введите b2: ");
bool isNumB2 = double.TryParse(Console.ReadLine(), out double b2);

if(!isNumK1 || !isNumB1 || !isNumK2 || !isNumB2)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

if (CheckParallelism(k1, k2))
{
    Console.WriteLine("Прямые параллельны или совпадают");
}
else
{
    Console.Write($"Координаты точки пересечения: ");
    PrintArray(FindCoordinates(k1, b1, k2, b2));
}



bool CheckParallelism(double k1, double k2)
{
    if (k1 == k2) return true;
    return false;
}


double[] FindCoordinates(double k1, double b1, double k2, double b2)
{
    double x = (b2-b1) / (k1-k2);
    double y = k1 * x + b1;
    
    double[] array = new double[2];
    array[0] = x;
    array[1] = y;
    return array;
}


void PrintArray(double[] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]})");
}