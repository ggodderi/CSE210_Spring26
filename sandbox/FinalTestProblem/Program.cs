

/*
An e-commerce fulfillment center uses an automated system to manage different types of drones and robots 
that move inventory. You have been tasked with building the core backend module that processes these 
vehicles and executes their daily tasks.

Every vehicle has an ID and a battery level, but different types of vehicles move differently and 
have unique operational rules.
*/
public class Supplier 
{
	public virtual void Deliver ()
    {
        Console.WriteLine("Delivering . . .");
    }
}  
public class Servicer : Supplier 
{
	public override void Deliver ()
    {
        Console.WriteLine("Servicer Delivering . . .");
    }
} 

class Program
{
    public static void Main(string[] args)
    {
        List<BaseVehicle> warehouseVehicles = new List<BaseVehicle>();

        Robot robot1 = new Robot(100, "R1", 100);
        Robot robot2 = new Robot(75, "R2", 75);
        Drone drone1 = new Drone(100, "D1", 5);
        Drone drone2 = new Drone(50, "D2", 5);

        warehouseVehicles.Add(drone1);
        warehouseVehicles.Add(drone2);
        warehouseVehicles.Add(robot1);
        warehouseVehicles.Add(robot2);

        foreach(BaseVehicle v in warehouseVehicles)
        {
            v.Move(10);
        }
Supplier mySupplier = new Servicer();
mySupplier.Deliver();


    }
}