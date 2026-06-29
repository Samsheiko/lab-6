class Program
{
    static void Main()
    {
        // 1. Создаем машину
        Car myCar = new Car("Toyota", 10.5, 7.2, 55.0);
        Console.WriteLine(myCar.ToString());

        // 2. Проверяем конструктор копирования
        FuelInfo copy = new FuelInfo(myCar);
        Console.WriteLine("Копия параметров: " + copy.ToString());

        // 3. Округляем значения
        myCar.ToInteger();
        Console.WriteLine("После округления: " + myCar.ToString());

        // 4. Работа методов
        Console.WriteLine($"Запас хода на трассе: {myCar.MaxHighwayDistance()} км");
        Console.WriteLine($"Средний расход: {myCar.AverageRate()} л/100км");
    }
}