using System;

public class FuelInfo
{
    private double _cityRate;    // Расход в городе
    private double _highwayRate; // Расход на трассе
    private double _tankVolume;  // Объем бака

    public FuelInfo() : this(0.0, 0.0, 0.0) { }

    public FuelInfo(double city, double highway, double tank)
    {
        _cityRate = city;
        _highwayRate = highway;
        _tankVolume = tank;
    }

    // Конструктор копирования
    public FuelInfo(FuelInfo other)
    {
        if (other == null) throw new ArgumentNullException(nameof(other));
        _cityRate = other._cityRate;
        _highwayRate = other._highwayRate;
        _tankVolume = other._tankVolume;
    }

    public double CityRate
    {
        get { return _cityRate; }
        set { _cityRate = value; }
    }

    public double HighwayRate
    {
        get { return _highwayRate; }
        set { _highwayRate = value; }
    }

    public double TankVolume
    {
        get { return _tankVolume; }
        set { _tankVolume = value; }
    }

    public int[] ToIntType()
    {
        return new int[] { (int)_cityRate, (int)_highwayRate, (int)_tankVolume };
    }

    public override string ToString()
    {
        return $"город: {_cityRate:F2}, трасса: {_highwayRate:F2}, бак: {_tankVolume:F2} л";
    }
}
