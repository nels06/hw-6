// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Сколько чисел необходимо ввести? ");
bool isNumber = int.TryParse(Console.ReadLine(), out int len);

if(!isNumber || len < 1)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

int[] arr = MakeArray(len);

PrintArray(arr);
Console.WriteLine($"Количество положительных чисел: {CountPositiveNumbers(arr)}");



int[] MakeArray(int length) 
{
    int[] newArray = new int[length];

    Console.WriteLine("Введите числа: ");

    for (int i = 0; i < length; i++)
    {
        try
        {
            newArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Введено НЕ число! Символ будет заменен на 0.");
        }
    }

    return newArray;
}


void PrintArray(int[] array)
{
    Console.Write("Массив: [ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]} ]");
}


int CountPositiveNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}