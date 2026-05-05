class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method

    public int  ExpectedMinutesInOven() => 40;

    // TODO: define the 'RemainingMinutesInOven()' method

    public int RemainingMinutesInOven(int minutes)
    {
        int remainingMinutes = ExpectedMinutesInOven() - minutes;
        return remainingMinutes;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method

    public int PreparationTimeInMinutes(int layer)
    {
        int minutesSpent = layer * 2;
        return minutesSpent;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method

    public int ElapsedTimeInMinutes(int layerNumber, int minutesInOven)
    {
        int minutesForLayers = layerNumber * 2;
        int sum = minutesForLayers + minutesInOven;
        return sum;
    }
}
