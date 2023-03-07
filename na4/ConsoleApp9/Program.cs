using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Бинарный поиск");
Console.WriteLine("Введите минимальное значение диапазаона:");
int i;
i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение диапазона:");
int p;
p = Convert.ToInt32(Console.ReadLine());
int[] massiv = Enumerable.Range(i, p).ToArray();
double low = 0;
double high = massiv.Length - 1;
double input = 0; // Входные данные пользователя
int ser = 0; // середина
Console.WriteLine($"Введите число от {i} до {p}");
input = Convert.ToDouble(Console.ReadLine());


while (massiv[ser] != input)
{
    ser = Convert.ToInt32(low + high / 2);

    if (input < massiv[ser])
    {
        high = ser - 1;
    }
    else if (input > massiv[ser])
    {
        low = ser + 1;
    }

    Console.WriteLine($"Число - {input} Позиция в массиве - {ser}");




}