class Program
{
    static void Main()
    {
        // 1. Вводим данные с клавиатуры
        Console.Write("Введите x: ");
        double inputX = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите y: ");
        double inputY = Convert.ToDouble(Console.ReadLine());

        // 2. Создаем объект класса Point
        Point myPoint = new Point(inputX, inputY);

        // 3. Вызываем метод и выводим результат
        double distance = myPoint.CalculateDistance();
        Console.WriteLine($"Расстояние до начала координат: {distance}");
    }
}