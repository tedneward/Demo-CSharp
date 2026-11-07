public readonly struct Money(decimal amount, string currency)
{
    public decimal Amount { get; } = amount;
    public string Currency { get; } = currency;

    public static Money operator +(Money m1, Money m2)
    {
        if (m1.Currency != m2.Currency)
            throw new InvalidOperationException("Cannot add Money with different currencies.");
        return new Money(m1.Amount + m2.Amount, m1.Currency);
    }
    public static Money operator -(Money m1, Money m2)
    {
        if (m1.Currency != m2.Currency)
            throw new InvalidOperationException("Cannot subtract Money with different currencies.");
        return new Money(m1.Amount - m2.Amount, m1.Currency);
    }
}