class RemoteControlCar
{
    private int drivenMeters = 0;
    private int batteryPercentage = 100;
    
    public static RemoteControlCar Buy()
    {
      RemoteControlCar car = new RemoteControlCar();
      return car;
    }

    public string DistanceDisplay()
    {
        return $"Driven {drivenMeters} meters";
    }

    public string BatteryDisplay()
    {
        if (batteryPercentage == 0)
        {
            return "Battery empty";
        }
        return $"Battery at {batteryPercentage}%";
    }
    
    public void Drive()
    {
        if(batteryPercentage > 0)
        {
            drivenMeters += 20;
            batteryPercentage -= 1;
        }
    }
}
