Console.WriteLine("Hello, Structs!");

// {{## BEGIN usage ##}}
TwoDPoint p = new TwoDPoint(1, 2);
Console.WriteLine($"p.X: {p.X}, p.Y: {p.Y}");

TwoDPoint p2 = p;   // copy, or alias?
p2.X = 3;
Console.WriteLine($"p.X: {p.X}, p.Y: {p.Y}");
Console.WriteLine($"p2.X: {p2.X}, p2.Y: {p2.Y}");
    // Notice: no aliasing, each is a different instance
// {{## END usage ##}}



