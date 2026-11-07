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
int xy1 = x + (y is null ? 0 : y.Value); // use ternary operator to provide a default value
int xy2 = x + y.GetValueOrDefault(); // use GetValueOrDefault() to provide a default value
int xy4 = x + (y ?? 0); // use null-coalescing operator to provide a default value
int y2 = y ??= 5; // use null-coalescing assignment operator to assign a default value if x is null

string? s1 = null;
Console.WriteLine($"s1 might have {s1?.Length} length"); // use null-conditional operator to safely access Length
    // can chain "?." dereferences; if any values in the chain are null, result will be null
// {{## END conditional ##}}
