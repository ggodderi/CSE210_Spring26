class Robot : BaseVehicle
{
    private double _maxWeight;
    public Robot(double batteryLevel, string ID, double maxWeight) : base(batteryLevel, ID)
    {
        _maxWeight = maxWeight;
    }

    public override void Move(int distance)
    {
        if (GetBatteryLevel() < 10)
        {
            Console.WriteLine("Battery Too Low, move");
        }
        else
        {
            DrainBattery(distance);
            Console.WriteLine($"{GetVehicleId()} is moving, carrying {_maxWeight} kilograms for {distance} meters");
        }

    }
}