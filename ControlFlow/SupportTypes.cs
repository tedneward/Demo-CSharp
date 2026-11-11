public abstract record Vehicle(string Name);
public record Car(string Make, string Model) : Vehicle(Make + " " + Model);
public record Truck(string Make, string Model) : Vehicle(Make + " " + Model);

// {{## BEGIN positional-point ##}}
public readonly struct Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y) => (X, Y) = (x, y);

    public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
}
// {{## END positional-point ##}}

