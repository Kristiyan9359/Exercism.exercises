class WeighingMachine
{
    private int precision;
    private double weight;
    private double tareAdjustment = 5;

    public WeighingMachine(int precision)
    {
        this.precision = precision;
    }


    public int Precision
    {
        get { return precision; }
    }

    public double Weight
    {
        get { return weight; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            weight = value;
        }
    }


    public double TareAdjustment
    {
        get { return tareAdjustment; }
        set { tareAdjustment = value; }
    }



    public string DisplayWeight
    {
        get
        {
            double adjustedWeight = weight - tareAdjustment;
            return adjustedWeight.ToString($"F{precision}") + " kg";
        }
    }
}
