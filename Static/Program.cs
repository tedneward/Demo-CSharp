Console.WriteLine("Hello, World!");

// {{## BEGIN usage ##}}
// Bring the namespace into scope with 'using MyExtensions;'
// Within the same project it's assumed in scope
string text = "Hello Extension Methods";
int count = text.WordCount(); // Returns 3
Console.WriteLine($"'{text}' word count is {count}");
// {{## END usage ##}}

// {{## BEGIN usage-2 ##}}
int num = 10;
bool even = num.IsEven(); // Returns true
bool odd = num.IsOdd;     // Returns false
Console.WriteLine($"Is {num} even {even} or odd {odd}?");
// {{## END usage-2 ##}}
