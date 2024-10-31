using Tyuiu.SenachevAV.Sprint3.Task3.V24.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Сеначев А.В. | АСОиУб-24-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #24                                                             *");
        Console.WriteLine("* Выполнил: Сеначев Андрей Вячеславович | АСОиУб-24-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Используя цикл foreach заменить буквы g  на * в строке: gft hggt ntg    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string str;

        Console.WriteLine("Введите строку:");
        str = Console.ReadLine();

        char kogo;

        Console.WriteLine("Введите заменяемый символ:");
        kogo = Convert.ToChar(Console.ReadLine());

        char kem;

        Console.WriteLine("Введите на какой символ его надо поменять:");
        kem = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.ReplaceCharInString(str, kogo, kem));

        Console.ReadLine();
    }
}