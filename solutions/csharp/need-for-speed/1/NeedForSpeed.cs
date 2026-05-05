class RemoteControlCar
{
    private readonly int speed;
    private readonly int batteryDrain;
    private int battery = 100;
    private int distanceDriven;

public RemoteControlCar(int speed, int batteryDrain)
{
    this.speed = speed;
    this.batteryDrain = batteryDrain;
}


    public bool BatteryDrained()
    {
       if(battery < batteryDrain)
       {
           return true;
       }
        return false;
    }

    public int DistanceDriven()
    {
        return distanceDriven;
    }

    public void Drive()
    {
       if (!BatteryDrained())
       {
           distanceDriven += speed;
           battery -= batteryDrain;
       }
    }

    public static RemoteControlCar Nitro()
    {
    return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private readonly int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while(!car.BatteryDrained())
        {
            car.Drive();
            if(car.DistanceDriven() >= distance)
            {
                return true;
            }
        }
        return false;
    }
}
