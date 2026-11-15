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

// {{## BEGIN collection-expression ##}}
// any collection type
string[] weekdays = 
    [ "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" ];
List<string> dayslist = 
    [ "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" ];
Dictionary<string, int> daysdict = 
    [ "Monday", 1, "Tuesday", 2, "Wednesday", 3, "Thursday", 4, "Friday", 5, "Saturday", 6, "Sunday", 7 ];

// property with expression body:
IEnumerable<int> MaxDays = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];

int Sum(IEnumerable<int> values) => values.Sum();
// As a parameter:
int sum = Sum([1, 2, 3, 4, 5]);
// {{## END collection-expression ##}}

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
// {{## END usage-2 ##}}

// {{## BEGIN usage-3 ##}}
    var first = FileLines("Collections.csproj").First();
    Console.WriteLine(first);
// {{## END usage-3 ##}}
}

ExploreEnumerators();