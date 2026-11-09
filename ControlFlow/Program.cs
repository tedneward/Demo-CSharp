Console.WriteLine("Hello, Patterns!");

// {{## BEGIN basic-syntax ##}}
// Notice: a single-expression method definition
decimal GetGroupTicketPrice(int visitorCount) => visitorCount switch
{
    1 => 12.0m,
    2 => 20.0m,
    3 => 27.0m,
    4 => 32.0m,
    5 or 6 or 7 or 8 => 35.0m,
    0 => 0.0m,
    _ => throw new ArgumentException($"Not supported number of visitors: {visitorCount}", nameof(visitorCount)),
};
Console.WriteLine(GetGroupTicketPrice(8));
// {{## END basic-syntax ##}}

// {{## BEGIN var-pattern-1 ##}}
bool IsAcceptable(int id, int absLimit) =>
    SimulateDataFetch(id) is var results 
    && results.Min() >= -absLimit 
    && results.Max() <= absLimit;

int[] SimulateDataFetch(int id)
{
    var rand = new Random();
    return Enumerable
               .Range(start: 0, count: 5)
               .Select(s => rand.Next(minValue: -10, maxValue: 11))
               .ToArray();
}
var result = IsAcceptable(3, 5);
// {{## END var-pattern-1 ##}}

// {{## BEGIN var-pattern-2 ##}}
// public record Point(int X, int Y);
Point Transform(Point point) => point switch
{
    var (x, y) when x < y => new Point(-x, y),
    var (x, y) when x > y => new Point(x, -y),
    var (x, y) => new Point(x, y),
};
Console.WriteLine(Transform(new Point(1, 2)));  // output: Point { X = -1, Y = 2 }
Console.WriteLine(Transform(new Point(5, 2)));  // output: Point { X = 5, Y = -2 }
// {{## END var-pattern-2 ##}}

// {{## BEGIN relational-pattern ##}}
string Classify(double measurement) => measurement switch
{
    < -4.0 => "Too low",
    > 10.0 => "Too high",
    double.NaN => "Unknown",
    _ => "Acceptable",
};
Console.WriteLine(Classify(13));  // output: Too high
Console.WriteLine(Classify(double.NaN));  // output: Unknown
Console.WriteLine(Classify(2.4));  // output: Acceptable
// {{## END relational-pattern ##}}

// {{## BEGIN logical-pattern ##}}
string Describe(double measurement) => measurement switch
{
    < -40.0 => "Too low",
    >= -40.0 and < 0 => "Low",
    >= 0 and < 10.0 => "Acceptable",
    >= 10.0 and < 20.0 => "High",
    >= 20.0 => "Too high",
    double.NaN => "Unknown",
};

Console.WriteLine(Describe(13));  // output: High
Console.WriteLine(Describe(-100));  // output: Too low
Console.WriteLine(Describe(5.7));  // output: Acceptable
// {{## END logical-pattern ##}}

// {{## BEGIN type-pattern ##}}
(decimal, string) CalculateToll(Vehicle vehicle) => vehicle switch
{
    Car c => (2.00m, c.Make),
    Truck t => (7.50m, t.Model),
    null => throw new ArgumentNullException(nameof(vehicle)),
    _ => throw new ArgumentException("Unknown type of a vehicle", nameof(vehicle)),
};
// {{## END type-pattern ##}}

// {{## BEGIN property-pattern-1 ##}}
bool IsChristmas(DateTime date) => date is { Month: 12, Day: 25 };
bool IsHanukkah(DateTime date) => date is { Year: 2026, Month: 12, 
    Day: 4 or 5 or 6 or 7 or 8 or 9 or 10 or 11 or 12 };

Console.WriteLine(IsChristmas(DateTime.Now));
Console.WriteLine(IsChristmas(DateTime.Now));
// {{## END property-pattern-1 ##}}

// {{## BEGIN property-pattern-2 ##}}
string TakeFive(object input) => input switch
{
    string { Length: >= 5 } s => s.Substring(0, 5),
    string s => s,

    ICollection<char> { Count: >= 5 } symbols => new string(symbols.Take(5).ToArray()),
    ICollection<char> symbols => new string(symbols.ToArray()),

    null => throw new ArgumentNullException(nameof(input)),
    _ => throw new ArgumentException("Not supported input type."),
};
Console.WriteLine(TakeFive("Hello, world!"));  // output: Hello
Console.WriteLine(TakeFive(new[] { '1', '2', '3', '4', '5', '6', '7' }));  // output: 12345
Console.WriteLine(TakeFive(new[] { 'a', 'b', 'c' }));  // output: abc
// {{## END property-pattern-2 ##}}

// {{## BEGIN list-pattern ##}}
int[] numbers = { 1, 2, 3 };

Console.WriteLine(numbers is [1, 2, 3]);  // True
Console.WriteLine(numbers is [1, 2, 4]);  // False
Console.WriteLine(numbers is [1, 2, 3, 4]);  // False
Console.WriteLine(numbers is [0 or 1, <= 2, >= 3]);  // True

List<int> morenumbers = new() { 1, 2, 3 };
if (more numbers is [var first, _, _])
{
    Console.WriteLine($"The first element of a three-item list is {first}.");
}
// Output:
// The first element of a three-item list is 1.
// {{## END list-pattern ##}}