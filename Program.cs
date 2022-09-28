bool Running = true;
int Op;
double number1;
double number2;
while (Running == true)
{
    Console.WriteLine("Выберете операцию:");
    Console.WriteLine("1.Сложить 2 числа");
    Console.WriteLine("2.Вычесть первое из второго");
    Console.WriteLine("3.Перемножить два числа");
    Console.WriteLine("4.Разделить первое на второе");
    Console.WriteLine("5.Возвести в степень N первое число");
    Console.WriteLine("6.Найти квадратный корень из числа");
    Console.WriteLine("7.Найти 1 процент от числа");
    Console.WriteLine("8.Найти факториал из числа");
    Console.WriteLine("9.Выйти из программы");

    Op = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите два числа:");
    number1 = Convert.ToDouble(Console.ReadLine());

    switch (Op)
    {
        case 1:
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"результат: {number1 + number2}");
            break;
        case 2:
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"результат: {number1 - number2}");
            break;
        case 3:
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"результат: {number1 * number2}");
            break;
        case 4:
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Результат: {number1 / number2}");
            break;
        case 5:
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Результат: {Math.Pow(number1, number2)} ");
            break;
        case 6:
            Console.WriteLine($"Квадратный корень из {Math.Sqrt(number1)}");
            break;
        case 7:

            Console.WriteLine($"Один процент от {number1 / 100}");
            break;
        case 8:
            double res = 0;
            for (int i = 2; i <= number1; i++)
            {
                res = number1 * i;
            }
            Console.WriteLine($"Факториал числа {number1} = {res}");
            break;
        case 9:
            Running = false;
            break;
    }
    Console.WriteLine("     ");
} 
        