using Tyuiu.SenachevAV.Sprint3.Task5.V4.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Сеначев А.В. | АСОиУб-24-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнил: Сеначев Андрей Вячеславович | АСОиУб-24-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* ///                                                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int value = 5;
        int startValue1 = 1;
        int stopValue1 = 3;
        int startValue2 = 1;
        int stopValue2 = 13;

        Console.WriteLine("Переменная X = " + value);
        Console.WriteLine("Старт шага первой суммы ряда= " + startValue1);
        Console.WriteLine("Конец шага первой суммы ряда= " + stopValue1);
        Console.WriteLine("Старт шага второй суммы ряда= " + startValue2);
        Console.WriteLine("Конец шага второй суммы ряда= " + stopValue2);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");



        Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(value, startValue1, stopValue1, startValue2, stopValue2));
        Console.ReadKey();
    }
}