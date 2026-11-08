Console.WriteLine("Greetings++!");
Console.WriteLine("=======================================");

// {{## BEGIN end-access-index ##}}
int[] xs = [0, 10, 20, 30, 40];
int last = xs[^1];
Console.WriteLine(last);  // output: 40

List<string> lines = ["one", "two", "three", "four"];
string prelast = lines[^2];
Console.WriteLine(prelast);  // output: three

string word = "Twenty";
Index toFirst = ^word.Length;
char first = word[toFirst];
Console.WriteLine(first);  // output: T
// {{## END end-access-index ##}}

Console.WriteLine("=======================================");

// {{## BEGIN range ##}}
int[] oneThroughTen = [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ];

Write(oneThroughTen, ..);       // 0..^0
Write(oneThroughTen, ..3);      // 0..3
Write(oneThroughTen, 2..);      // 2..^0
Write(oneThroughTen, 3..5);     // 3..5
Write(oneThroughTen, ^2..);     // ^2..^0
Write(oneThroughTen, ..^3);     // 0..^3
Write(oneThroughTen, 3..^4);    // 3..^4
Write(oneThroughTen, ^4..^2);   // ^4..^2

static void Write(int[] values, Range range) =>
    Console.WriteLine($"{range}:\t{string.Join(", ", values[range])}");
// {{## END range ##}}

Console.WriteLine("=======================================");

// {{## BEGIN checking ##}}
uint a = uint.MaxValue;
unchecked {
    Console.WriteLine(a + 3);  // output: 2
}
try {
    checked {
        Console.WriteLine(a + 3); // boom! This will throw an OverflowException
    }
}
catch (OverflowException e) {
    Console.WriteLine(e.Message);  // output: Arithmetic operation resulted in an overflow.
}
// {{## END checking ##}}

Console.WriteLine("=======================================");

// {{## BEGIN usage ##}}
Point p1 = new Point(1, 2);
Point p2 = new Point(3, 4);
Point p3 = p1 + p2; // Uses the overloaded + operator
Console.WriteLine($"p1: {p1}, p2: {p2}, p3: {p3}"); // Output: p1: (1, 2), p2: (3, 4), p3: (4, 6)
// {{## END usage ##}}

Console.WriteLine("=======================================");

// {{## BEGIN checked ##}}
Point p4 = new Point(int.MaxValue, int.MaxValue);
Point p5 = new Point(1, 1);
Point boom = p4 + p5; // No boom, we just overflowed and wrapped around to negative values
Console.WriteLine($"boom: {boom}");
try {
    Point boomChecked = checked(p4 + p5); // This will throw an OverflowException
}
catch (OverflowException e) {
    Console.WriteLine($"Checked operation resulted in an overflow: {e.Message}");
}
// {{## END checked ##}}
