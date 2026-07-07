class Drone : BaseVehicle
{
    private double _maxAltitude;
    public Drone(double batteryLevel, string ID, double maxAltitude) : base(batteryLevel, ID)
    {
        _maxAltitude = maxAltitude;
    }

    public override void Move(int distance)
    {
        if (GetBatteryLevel() < 20)
        {
            Console.WriteLine("Battery Too Low, can't fly");
        }
        else
        {
            DrainBattery(distance * 2);
            Console.WriteLine($"{GetVehicleId()} is flying at {_maxAltitude} meters high for {distance} meters");
        }

    }
}