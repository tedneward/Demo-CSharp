// `static` says that this is a definition for extension methods
public static class StringExtensions
{
    // The 'this' keyword specifies that WordCount extends the string type
    public static int WordCount(this string str)
    {
        return str.Split([' ', '.', '?'], StringSplitOptions.RemoveEmptyEntries).Length;
    }
}