
abstract class BaseVehicle
{
    private double _batteryLevel;
    private string _vehicleId;

    public BaseVehicle(double batteryLevel, string vehicleId)
    {
        _batteryLevel = batteryLevel;
        _vehicleId = vehicleId;
    }

    private void CheckBatteryLevel()
    {
        if (_batteryLevel < 0)
        {
            _batteryLevel = 0;
        }
        else if (_batteryLevel > 100)
        {
            _batteryLevel = 100;
        }        
    }
    public void ChargeBattery()
    {
        _batteryLevel += 20;
        CheckBatteryLevel();
    }
    public double GetBatteryLevel()
    {
        return _batteryLevel;
    }

    public void DrainBattery(double amount)
    {
        _batteryLevel -= amount;
        CheckBatteryLevel();
    }

    public string GetVehicleId()
    {
        return _vehicleId;
    }

    public abstract void Move(int distance);
}