global using System.Collections;
global using System.Collections.Generic;
global using System.Linq.Expressions;

Console.WriteLine("Hello, Collections!");

void ExploreArrays() {

}

void ExploreLists() {

}

void ExploreDictionaries() {

}

void ExploreQueues() {

}

void ExploreStacks() {

}

// {{## BEGIN yield-return ##}}
IEnumerable<string> FileLines(string fn)
{
    using (var sr = new StreamReader(fn))
    {
        string? current = null;
        while ((current = sr.ReadLine()) != null)
        {
            yield return current;
        }
    }
}
// {{## BEGIN yield-return ##}}
void ExploreEnumerators()
{
// {{## BEGIN usage-1 ##}}
    foreach (var l in new LineEnumerable("Collections.csproj"))
    {
        Console.WriteLine(l);
    }
// {{## END usage-1 ##}}
// {{## BEGIN usage-2 ##}}
    foreach (var l in FileLines("Collections.csproj"))
    {
        Console.WriteLine(l);
    }

    var first = FileLines("Collections.csproj").First();
    Console.WriteLine(first);
// {{## END usage-2 ##}}
}

ExploreEnumerators();