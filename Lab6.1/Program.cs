using System;

// Базовый класс: Параметры расхода
public class FuelInfo
{
    public double CityRate;    // Расход в городе
    public double HighwayRate; // Расход на трассе
    public double TankVolume;  // Объем бака

    // Конструктор
    public FuelInfo(double city, double highway, double tank)
    {
        CityRate = city;
        HighwayRate = highway;
        TankVolume = tank;
    }

    // Конструктор копирования
    public FuelInfo(FuelInfo other)
    {
        this.CityRate = other.CityRate;
        this.HighwayRate = other.HighwayRate;
        this.TankVolume = other.TankVolume;
    }

    // Метод приведения к целому типу
    public void ToInteger()
    {
        CityRate = (int)CityRate;
        HighwayRate = (int)HighwayRate;
        TankVolume = (int)TankVolume;
    }

    public override string ToString()
    {
        return $"Расход: город {CityRate}, трасса {HighwayRate}. Бак: {TankVolume} л";
    }
}

// Дочерний класс: Марка машины
public class Car : FuelInfo
{
    public string Brand;

    public Car(string brand, double city, double highway, double tank)
        : base(city, highway, tank)
    {
        Brand = brand;
    }

    // Метод 1: Сколько км проедет по трассе на полном баке
    public double MaxHighwayDistance() => (TankVolume / HighwayRate) * 100;

    // Метод 2: Средний расход (смешанный цикл)
    public double AverageRate() => (CityRate + HighwayRate) / 2;

    public override string ToString()
    {
        return $"Марка: {Brand}. " + base.ToString();
    }
}


