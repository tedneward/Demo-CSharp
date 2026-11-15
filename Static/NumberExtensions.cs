public static class NumberExtensions
{
    // Defines an extension block for the int type
    extension(int number)
    {
        public bool IsEven() => number % 2 == 0;
        public bool IsOdd => number % 2 != 0; // C# 14 also supports extension properties
    }
}
