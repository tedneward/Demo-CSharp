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

    public string ToString()
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

    public string ToString() => $"({X}, {Y}, {Z})";
}
// {{## END terse ##}}
