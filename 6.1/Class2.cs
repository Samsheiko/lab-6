using System;

// Дочерний класс: Марка машины
public class Car : FuelInfo
{
    private string _brand;

    public Car() : this("Неизвестно", 0.0, 0.0, 0.0) { }

    public Car(string brand, double city, double highway, double tank)
        : base(city, highway, tank)
    {
        _brand = string.IsNullOrWhiteSpace(brand) ? "Неизвестно" : brand;
    }

    public Car(Car other) : base(other)
    {
        if (other == null) throw new ArgumentNullException(nameof(other));
        _brand = other._brand;
    }

    public string Brand
    {
        get { return _brand; }
        set { _brand = string.IsNullOrWhiteSpace(value) ? "Неизвестно" : value; }
    }

    public double MaxHighwayDistance()
    {
        if (HighwayRate <= 0) return 0;
        return (TankVolume / HighwayRate) * 100;
    }

    public double AverageRate()
    {
        return (CityRate + HighwayRate) / 2;
    }

    public override string ToString()
    {
        return $"марка: {_brand}, {base.ToString()}";
    }
}
