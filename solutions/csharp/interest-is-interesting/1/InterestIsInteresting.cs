static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if(balance < 1000 && balance >= 0)
        {
            return 0.5f;
        }
        else if(balance >= 1000 && balance < 5000)
        {
            return 1.621f;
        }
        else if(balance >= 5000)
        {
            return 2.475f;
        }
        else
            return 3.213f;
    }

    public static decimal Interest(decimal balance)
    {
      if(balance < 1000 && balance >= 0)
        {
            return balance * 0.5m / 100;
        }
        else if(balance >= 1000 && balance < 5000)
        {
            return balance * 1.621m / 100;
        }
        else if(balance >= 5000)
        {
            return balance * 2.475m / 100;
        }
        else
            return balance * 3.213m / 100;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
              if(balance < 1000 && balance >= 0)
        {
            return (balance * 0.5m / 100) + balance;
        }
        else if(balance >= 1000 && balance < 5000)
        {
            return (balance * 1.621m / 100) + balance;
        }
        else if(balance >= 5000)
        {
            return (balance * 2.475m / 100) + balance;
        }
        else
            return (balance * 3.213m / 100) + balance;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
     int years = 0;
        while(balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            years++;
        }
        return years;
    }
}
