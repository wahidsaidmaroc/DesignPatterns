using System;

public class House
{
    public int Rooms { get; set; }
    public string RoofType { get; set; }
    public int Windows { get; set; }

    public override string ToString()
    {
        return $"House with {Rooms} rooms, {RoofType} roof, and {Windows} windows.";
    }
}

public interface IHouseBuilder
{
    void BuildRooms(int number);
    void BuildRoof(string type);
    void BuildWindows(int number);
    House GetHouse();
}

public class ConcreteHouseBuilder : IHouseBuilder
{
    private House _house = new House();

    public void BuildRooms(int number)
    {
        _house.Rooms = number;
    }

    public void BuildRoof(string type)
    {
        _house.RoofType = type;
    }

    public void BuildWindows(int number)
    {
        _house.Windows = number;
    }

    public House GetHouse()
    {
        return _house;
    }
}

public class Director
{
    private IHouseBuilder _builder;

    public Director(IHouseBuilder builder)
    {
        _builder = builder;
    }

    public void ConstructHouse()
    {
        _builder.BuildRooms(4);
        _builder.BuildRoof("Gable");
        _builder.BuildWindows(10);
    }
}

class Program
{
    static void Main()
    {
        IHouseBuilder builder = new ConcreteHouseBuilder();
        Director director = new Director(builder);

        director.ConstructHouse();
        House house = builder.GetHouse();

        Console.WriteLine(house);
    }
}
