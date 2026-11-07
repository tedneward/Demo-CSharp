// {{## BEGIN initializers ##}}
public class Book(string title, string author, DateOnly published)
{
    public string ISBN { get; set; } = "";
    public string Title { get; set; } = title;
    public string Author { get; set; } = author;
    public DateOnly Published { get; set; } = published;
// {{## END initializers ##}}

// {{## BEGIN single-expression ##}}
    public int Year => Published.Year;
    public string Summary => $"{Title} by {Author}, published in {Year}";

    public override string ToString() => $"{Title} by {Author}, published in {Year}";
// {{## END single-expression ##}}
}
