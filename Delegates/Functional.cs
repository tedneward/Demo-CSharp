public static class FunctionalExtensions
{
    public static TAccumulate FoldLeft<TSource, TAccumulate>(
        this IEnumerable<TSource> source,
        TAccumulate seed,
        Func<TAccumulate, TSource, TAccumulate> func)
    {
        if (source == null) throw new ArgumentNullException(nameof(source));
        if (func == null) throw new ArgumentNullException(nameof(func));

        TAccumulate accumulator = seed;
        foreach (TSource item in source)
        {
            accumulator = func(accumulator, item);
        }
        return accumulator;
    }
}

public class Functional
{
    public static TAccumulate FoldLeft<TSource, TAccumulate>(
        IEnumerable<TSource> source,
        TAccumulate seed,
        Func<TAccumulate, TSource, TAccumulate> func)
    {
        if (source == null) throw new ArgumentNullException(nameof(source));
        if (func == null) throw new ArgumentNullException(nameof(func));

        TAccumulate accumulator = seed;
        foreach (TSource item in source)
        {
            accumulator = func(accumulator, item);
        }
        return accumulator;
    }
}
