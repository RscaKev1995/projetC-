public class Vehicle
{
    public string NameOfTheVehicle { get; set; }
    public int DateConstruct { get; set; }
    public ConsoleColor Color { get; set; }

    public Vehicle(string nameOfTheVehicle, int dateConstruct, ConsoleColor color)
    {
        this.NameOfTheVehicle = nameOfTheVehicle;
        this.DateConstruct = dateConstruct;
        this.Color = color;
    }
}

public class VehicleRace : Vehicle
{
    public int DrivingSkills { get; set; }
    public double PercentageOfLuck { get; set; }
    public string Brand { get; set; }
    public int MaxSpeed { get; set; } 

    public VehicleRace(string nameOfTheVehicle, int dateConstruct, string brand, int drivingSkills, double percentageOfLuck, ConsoleColor color)
        : base(nameOfTheVehicle, dateConstruct, color)
    {
        this.Brand = brand;
        this.DrivingSkills = drivingSkills;
        this.PercentageOfLuck = percentageOfLuck;
    }
}

public class VehicleFriend : Vehicle
{
    public string Brand { get; set; }

    public VehicleFriend(string nameOfTheVehicle, int dateConstruct, string brand, ConsoleColor color)
        : base(nameOfTheVehicle, dateConstruct, color)
    {
        this.Brand = brand;
    }
}