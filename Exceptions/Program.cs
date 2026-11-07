using ContextData = System.Collections.Generic.Dictionary<string, object>;

Console.WriteLine("Hello, Exceptions!");

// {{## BEGIN try-catch ##}}
try {
    int[] numbers = { 1, 2, 3 };
    Console.WriteLine(numbers[5]); // This will throw an IndexOutOfRangeException
}
catch (IndexOutOfRangeException ex) {
    // Handle the exception
    Console.WriteLine($"Index out of bounds: {ex.Message}");
}
catch (Exception ex) {
    // Handle any other exceptions
    Console.WriteLine($"An error occurred: {ex.Message}");
    DumpEx(ex);
}
// {{## END try-catch ##}}

// {{## BEGIN tryparse ##}}
var inputs = new [] { "123", "abc", "456" };
foreach (var input in inputs) {
    if (int.TryParse(input, out int result)) {
        Console.WriteLine($"Parsed successfully: {result}");
    }
    // ... vs ...
    try {
        int value = int.Parse(input);
        Console.WriteLine($"Parsed successfully: {value}");
    }
    catch (FormatException ex) {
        Console.WriteLine($"Failed to parse '{input}': {ex.Message}");
    }
}
// {{## END tryparse ##}}

Console.WriteLine("==============================================");
DemonstrateDebuggingAdvantage();
Console.WriteLine("==============================================");

// {{## BEGIN throw ##}}
try {
    CallOne();
}
catch (MyException ex) {
    Console.WriteLine($"Caught MyException: {ex.Message}");
}
catch {
    Console.WriteLine("Caught something wildly unexpected.");
}
void CallOne() { CallTwo(); }
void CallTwo() { CallThree(); }
void CallThree() { throw new MyException("Something went wrong in CallThree!"); }
// {{## END throw ##}}

// {{## BEGIN filters-1 ##}}
//using ContextData = System.Collections.Generic.Dictionary<string, object>;
void DemonstrateDebuggingAdvantage() {
    var contextData = new ContextData
    {
        ["RequestId"] = Guid.NewGuid(),
        ["UserId"] = "user123",
        ["Timestamp"] = DateTime.Now
    };

    try {
        Level1Method(contextData);
    }
    catch (Exception ex) when (LogAndFilter(ex, contextData))
    {
        // This catch block may never execute if LogAndFilter returns false.
        // But LogAndFilter can examine the exception while the stack is intact.
        Console.WriteLine("Exception handled after logging");
    }
}
// {{## END filters-1 ##}}

// {{## BEGIN filters-2 ##}}
void Level1Method(ContextData context)
{ Level2Method(context); }

void Level2Method(ContextData context)
{ Level3Method(context); }

void Level3Method(ContextData context)
{ throw new InvalidOperationException("Error in deep call stack"); }
// {{## END filters-2 ##}}

// {{## BEGIN filters-3 ##}}
bool LogAndFilter(Exception ex, ContextData context)
{
    // This method runs before stack unwinding.
    // Full call stack and local variables are still available.
    Console.WriteLine($"Exception occurred: {ex.Message}");
    Console.WriteLine($"Request ID: {context["RequestId"]}");
    Console.WriteLine($"Full stack trace preserved: {ex.StackTrace}");
    
    // Return true to handle the exception, false to continue search.
    return ex.Message.Contains("deep call stack");
}
// {{## END filters-3 ##}}

// {{## BEGIN exinfo ##}}
void DumpEx(Exception ex) {
    Console.WriteLine($"Exception Type: {ex.GetType().Name}");
    Console.WriteLine($"Message: {ex.Message}");
    Console.WriteLine($"Stack Trace: {ex.StackTrace}");
    Console.WriteLine($"Source: {ex.Source}");
    Console.WriteLine($"Target Site: {ex.TargetSite}");
    Console.WriteLine($"Help Link: {ex.HelpLink}");
    Console.WriteLine($"HResult: {ex.HResult}");
    if (ex.Data != null && ex.Data.Count > 0) {
        foreach (var key in ex.Data.Keys) {
            Console.WriteLine($"Data[{key}]: {ex.Data[key]}");
        }
    }
    else {
        Console.WriteLine("No additional data.");
    }
}   
// {{## END exinfo ##}}