Console.WriteLine("Hello, Exceptions!");

// {{## BEGIN try-catch ##}}
try {
    int[] numbers = { 1, 2, 3 };
    Console.WriteLine(numbers[5]); // This will throw an IndexOutOfRangeException
}
catch (IndexOutOfRangeException ex) {
    Console.WriteLine($"Index out of bounds: {ex.Message}");
}
catch (Exception ex) {
    // Handle the exception
    Console.WriteLine($"An error occurred: {ex.Message}");
}
// {{## END try-catch ##}}

// {{## BEGIN throw ##}}
try
{
}
catch (Exception ex)
{
    // Handle any other exceptions
    Console.WriteLine($"An error occurred: {ex.Message}");
}
// {{## END throw ##}}
