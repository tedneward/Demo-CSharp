Console.WriteLine("Nullability examples");

// {{## BEGIN simple ##}}
int x = 5; // can never be assigned null
int? y = null; // can be assigned null
//int xy = x + y; // error: cannot convert null to int
Console.WriteLine($"x: {x}, y: {y}");
Console.WriteLine(y.ToString()); 
    // safe to call ToString() on a nullable type, will return ""
//y.Value.ToString(); 
    // unsafe to call Value on a nullable type, will throw InvalidOperationException if y is null
// {{## END simple ##}}

// {{## BEGIN conditional ##}}
int xy1 = x + (y == null ? 0 : y.Value); // use conditional operator to provide a default value
int xy2 = x + y.GetValueOrDefault(); // use GetValueOrDefault() to provide a default value
int xy3 = x + (y?.Value);
int xy4 = x + (y ?? 0); // use null-coalescing operator to provide a default value
int y2 = y ?? 0; // use null-coalescing operator to provide a default value
int y3 = x ??= 5; // use null-coalescing assignment operator to assign a default value if x is null
// {{## END conditional ##}}
