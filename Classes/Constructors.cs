// {{## BEGIN primary ##}}
class Ctor1(int x, int y, int z)
{

    public Ctor1(int x, int y) : this(x, y, 0) { }

    public int X { get; set; } = x;
    public int Y() { return y; }

    public override string ToString()
    {
        return z.ToString();
    }
}
// {{## END primary ##}}

// {{## BEGIN static ##}}
class Ctor2
{
    public Ctor2()
    {
        Console.WriteLine("Instance constructor called");
    }

    static Ctor2() { Console.WriteLine("Static constructor called"); }
}
// {{## END static ##}}
