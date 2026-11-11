Console.WriteLine("Hello, World!");

// {{## BEGIN usage ##}}
Person p = new Person("John", "Doe", 30);
var j = new Person("Jane", "Doe", 25);
Person f = new("Fred", "Flintstone", 40);
Person w = new() { FirstName = "Wilma", LastName = "Flintstone", Age = 35 };
//var o = new(); // Error! Can't infer target type for new()
// {{## END usage ##}}

new Ctor1(1, 2, 3);
new Ctor2();

// {{## BEGIN anonymous ##}}
var anon = new { Name = "John", Age = 30 };
Console.WriteLine("{0} is {1} years old.", anon.Name, anon.Age);
Console.WriteLine(anon.GetType().Name); 
    // Displays the compiler-generated name of the anonymous type

object GetAnon() { return new { Name = "Jane", Age = 25 }; }
var anon2 = GetAnon();
//Console.WriteLine(anon2.Name); 
    // Error! Can't access properties of an anonymous type through object ref
// {{## END anonymous ##}}

// {{## BEGIN field ##}}
var book = new Book("F. Scott Fitzgerald") { Title = "The Great Gatsby", PublishedDate = new DateOnly(1925, 4, 10) };
//book.ISBN = null; // Throws ArgumentNullException
//var book2 = new Book("Ted Neward"); // Error: Book.Title must be set
var book2 = new Book("Ted Neward") { Title = "Working Title" };
Console.WriteLine($"{book2.Author} done writing yet? {book2.Published}");
// {{## END field ##}}
