public record struct Point(int X, int Y)
{
    public static Point operator checked +(Point left, Point right)
    {
        checked { return new Point(left.X + right.X, left.Y + right.Y); }
    }
    public static Point operator checked -(Point left, Point right)
    {
        checked { return new Point(left.X - right.X, left.Y - right.Y); }
    }
    
    public static Point operator +(Point left, Point right)
    {
        return new Point(left.X + right.X, left.Y + right.Y);
    }
    public static Point operator -(Point left, Point right)
    {
        return new Point(left.X - right.X, left.Y - right.Y);
    }
}