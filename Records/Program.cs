Console.WriteLine("Hello, World!");

// {{## BEGIN usage ##}}
var c = new Temperature(0.0).Celsius; // 0.0
var f = c.Fahrenheit;
Console.WriteLine(f); // Output: 32.0
var f2 = new Temperature(17.0).Fahrenheit;
Console.WriteLine(f2); // Output: 359.4
// {{## END usage ##}}

// {{## BEGIN class-equality ##}}
// Person is a record type with three properties: FirstName, LastName, and Age
var person1 = new Person("Grace", "Hopper", 39);
var person2 = person1; // both point to the same object
Console.WriteLine(ReferenceEquals(person1, person2)); // True

var person3 = new Person("Grace", "Hopper", 39);

Console.WriteLine(person1 == person3);              // True
Console.WriteLine(ReferenceEquals(person1, person3)); // False
// {{## END class-equality ##}}

// {{## BEGIN struct-equality ##}}
// Record struct — assignment copies the data
var c1 = new Coordinate(47.6062, -122.3321);
var c2 = c1;
c2.Longitude = 0.0; // mutating c2 doesn't affect c1
Console.WriteLine(c1.Longitude); // -122.3321
Console.WriteLine(c2.Longitude); // 0
// {{## END struct-equality ##}}

// {{## BEGIN with ##}}
var fred = new Person("Fred", "Flintstone", 40);
var wilma = fred with { FirstName = "Wilma", Age = 35 }; // Creates a new Person object with FirstName changed to "Wilma"
Console.WriteLine(fred); // Output: Person { FirstName = Fred, LastName = Flintstone, Age = 40 }
Console.WriteLine(wilma); // Output: Person { FirstName = Wilma, LastName = Flintstone, Age = 40 }
// {{## END with ##}}

// {{## BEGIN deconstruction ##}}
var (first, last, _) = new Person("Grace", "Hopper", 39);
Console.WriteLine($"{first} {last}"); // Grace Hopper

List<Point> points = [ new Point(0, 0), new Point(1,1), new Point(2,2) ];
foreach (var (x, y) in points)
{
    Console.WriteLine($"({x}, {y})");
}
// {{## END deconstruction ##}}

public record struct Coordinate(double Latitude, double Longitude);

// {{## BEGIN additional-members ##}}
public readonly record struct Temperature(double Celsius)
{
    public double Fahrenheit => Celsius * 9.0 / 5.0 + 32.0;
}
// {{## END additional-members ##}}
