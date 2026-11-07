Console.WriteLine("Hello, World!");

// {{## BEGIN with ##}}
var fred = new Person("Fred", "Flintstone", 40);
var wilma = fred with { FirstName = "Wilma", Age = 35 }; // Creates a new Person object with FirstName changed to "Wilma"
Console.WriteLine(fred); // Output: Person { FirstName = Fred, LastName = Flintstone, Age = 40 }
Console.WriteLine(wilma); // Output: Person { FirstName = Wilma, LastName = Flintstone, Age = 40 }
// {{## END with ##}}

