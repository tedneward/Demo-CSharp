// {{## BEGIN verbose ##}}
struct TwoDPoint
{
    public int X { get; set; }
    public int Y { get; set; }

    public TwoDPoint(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
// {{## END verbose ##}}

// {{## BEGIN terse ##}}
struct ThreeDPoint(int x, int y, int z)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;
    public int Z { get; set; } = z;

    public override string ToString() => $"({X}, {Y}, {Z})";
}
// {{## END terse ##}}

// {{## BEGIN readonly ##}}
readonly struct LatLong(double latitude, double longitude)
{
    public double Latitude { get; init; } = latitude;
    public double Longitude { get; init; } = longitude;

    public override string ToString() => $"({Latitude}, {Longitude})";
}
// {{## END readonly ##}}
