internal class Program
{
    private static double ReadPositiveDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("ошибка: пустой ввод");
                continue;
            }

            input = input.Replace('.', ','); 

            if (double.TryParse(input, out double result))
            {
                if (result >= 0)
                    return result;

                Console.WriteLine("ошибка: значение не может быть отрицательным");
                continue;
            }

            Console.WriteLine("ошибка: введите число");
        }
    }

    private static void Main()
    {
        Console.WriteLine("=== тестирование ===\n");

        Console.Write("марка машины: ");
        string brand = Console.ReadLine();

        double city = ReadPositiveDouble("расход в городе (л/100км): ");
        double highway = ReadPositiveDouble("расход на трассе (л/100км): ");
        double tank = ReadPositiveDouble("объем бака (л): ");

        Car myCar = new Car(brand, city, highway, tank);

        Console.WriteLine($"\nобъект: {myCar}");


        Console.WriteLine($"копия базового класса: {new FuelInfo(myCar)}");
        Console.WriteLine($"копия дочернего класса: {new Car(myCar)}");

        Console.WriteLine($"запас хода: {myCar.MaxHighwayDistance():F2} км");
        Console.WriteLine($"ср. расход: {myCar.AverageRate():F2} л/100км");

        int[] intFields = myCar.ToIntType();
        Console.WriteLine($"к целому типу: город={intFields[0]}, трасса={intFields[1]}, бак={intFields[2]}");

        Console.WriteLine("\nнажмите любую клавишу...");
        Console.ReadKey();
    }
}