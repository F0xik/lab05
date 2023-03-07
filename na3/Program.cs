Console.WriteLine("Формулы = 1; Циклы = 2");
int vibor;
vibor = Convert.ToInt32(Console.ReadLine());
if (vibor == 1)
{
    Console.WriteLine("Выбран раздел: формулы");
    Console.WriteLine("Геометрическая прогрессия");  // Геометрическая
    Console.WriteLine("Введите первый член"); // a1
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите знаменатель  прогрессии"); // q
    double q = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите номер последнего члена"); // n - число элементов
    double n0 = Convert.ToDouble(Console.ReadLine());

    double s = b1 * ((Math.Pow(q, n0)) - 1) / (q - 1);
    Console.WriteLine($"Сумма геометрической прогрессии равна: {s}");

    Console.WriteLine("Арифметическая прогрессия");
    Console.WriteLine("Введите первый член");  // Арифметическая
    double a1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите разность");
    double d = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите номер последнего члена"); // n - число элементов
    double n = Convert.ToDouble(Console.ReadLine());

    double s1 = (a1 + d) * n;

    Console.WriteLine($"Сумма арифметической равна {s1}");
}

if (vibor == 2)

{
    Console.WriteLine("Выбран раздел: циклы");
    Console.WriteLine("Геометрическая прогрессия"); ; // цикл геометрический
    Console.WriteLine("Введите первый член"); // a1
    double b11 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите знаменатель  прогрессии"); // q
    double q1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите номер последнего члена"); // n - число элементов
    double n00 = Convert.ToDouble(Console.ReadLine());
    double umn = b11;
    for (double i = 0; i < (n00 - 1); i++)
    {
        b11 = b11 * q1;
        umn = umn + b11;

    }
    Console.WriteLine(umn);

    Console.WriteLine("Арифметическая прогрессия"); // цикл арифметической
    Console.WriteLine("Введите первый член");
    double a2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите разность");
    double d1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите число элементов");
    double n1 = Convert.ToDouble(Console.ReadLine());

    double lastnumber = a2;
    double sum = a2;


    for (double i = 0; i < (n1 - 1); i++)
    {
        lastnumber = lastnumber + d1;
        sum = sum + lastnumber;

    }
    Console.WriteLine(sum);


}

