// {{## BEGIN initializers ##}}
public class Book(string author)
{
    public string Author { get; set; } = author;
    public required string Title { get; set; }
    public bool Published { 
        get => PublishedDate != null;
    }
    public DateOnly? PublishedDate { get; set; } = default;
// {{## END initializers ##}}

// {{## BEGIN single-expression ##}}
    public int Year => PublishedDate.Value.Year;
    public string Summary => $"{Title} by {Author}, published in {Year}";

    public override string ToString() => $"{Title} by {Author}, published in {Year}";
// {{## END single-expression ##}}

// {{## BEGIN field ##}}
    public string ISBN { 
        get => field.ToString().ToUpper();
        set => field = value ?? 
            throw new ArgumentNullException(nameof(value), "ISBN cannot be null");
    } = GetNewISBN();
    public static string GetNewISBN() => Guid.NewGuid().ToString();
// {{## END field ##}}
}
