using System;

public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }

    private static void ValidateSameCurrency(CurrencyAmount amountA, CurrencyAmount amountB)
    {
        if (amountA.currency != amountB.currency)
        {
            throw new ArgumentException();
        }
    }

    public static bool operator ==(CurrencyAmount amountA, CurrencyAmount amountB)
    {
        ValidateSameCurrency(amountA, amountB);
        return amountA.amount == amountB.amount;
    }

    public static bool operator !=(CurrencyAmount amountA, CurrencyAmount amountB)
    {
        return !(amountA == amountB);
    }

    public static bool operator <(CurrencyAmount amountA, CurrencyAmount amountB)
    {
        ValidateSameCurrency(amountA, amountB);
        return amountA.amount < amountB.amount;
    }

    public static bool operator >(CurrencyAmount amountA, CurrencyAmount amountB)
    {
        ValidateSameCurrency(amountA, amountB);
        return amountA.amount > amountB.amount;
    }

    public static bool operator <=(CurrencyAmount amountA, CurrencyAmount amountB)
    {
        return amountA < amountB || amountA == amountB;
    }

    public static bool operator >=(CurrencyAmount amountA, CurrencyAmount amountB)
    {
        return amountA > amountB || amountA == amountB;
    }

    public static CurrencyAmount operator +(CurrencyAmount amountA, CurrencyAmount amountB)
    {
        ValidateSameCurrency(amountA, amountB);
        return new CurrencyAmount(amountA.amount + amountB.amount, amountA.currency);
    }

    public static CurrencyAmount operator -(CurrencyAmount amountA, CurrencyAmount amountB)
    {
        ValidateSameCurrency(amountA, amountB);
        return new CurrencyAmount(amountA.amount - amountB.amount, amountA.currency);
    }

    public static CurrencyAmount operator *(CurrencyAmount amountA, decimal multiplier)
    {
        return new CurrencyAmount(amountA.amount * multiplier, amountA.currency);
    }

    public static CurrencyAmount operator *(decimal multiplier, CurrencyAmount amountA)
    {
        return amountA * multiplier;
    }

    public static CurrencyAmount operator /(CurrencyAmount amountA, decimal divisor)
    {
        return new CurrencyAmount(amountA.amount / divisor, amountA.currency);
    }

    public static implicit operator decimal(CurrencyAmount amount)
    {
        return amount.amount;
    }

    public static explicit operator string(CurrencyAmount amount)
    {
        return $"{amount.amount} {amount.currency}";
    }

    public static explicit operator double(CurrencyAmount amount)
    {
        return (double)amount.amount;
    }

    public override bool Equals(object obj)
    {
        return obj is CurrencyAmount other && this == other;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(amount, currency);
    }

    public override string ToString()
    {
        return $"{amount} {currency}";
    }
}