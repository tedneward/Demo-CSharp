Console.WriteLine("Hello, Patterns!");

// {{## BEGIN basic-syntax ##}}
decimal GetGroupTicketPrice(int visitorCount) => visitorCount switch
{
    1 => 12.0m,
    2 => 20.0m,
    3 => 27.0m,
    4 => 32.0m,
    0 => 0.0m,
    _ => throw new ArgumentException($"Not supported number of visitors: {visitorCount}", nameof(visitorCount)),
};
// {{## END basic-syntax ##}}

// {{## BEGIN or-pattern ##}}
// {{## END or-pattern ##}}

decimal GetGroupTicketPrice2(int visitorCount) => visitorCount switch
{
    1 or 2 or 3 or 4 => 32.0m,
    0 => 0.0m,
    _ => throw new ArgumentException($"Not supported number of visitors: {visitorCount}", nameof(visitorCount)),
};
