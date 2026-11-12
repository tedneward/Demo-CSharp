Console.WriteLine("Hello, Delegates!");

Console.WriteLine("==============================================");

// {{## BEGIN delegate-usage ##}}
GreetingDelegate gd = null;
gd += Console.WriteLine; // this WILL trigger a CS8600 warning about null literal use
gd("Greetings, from a delegate!");
// {{## END delegate-usage ##}}

Console.WriteLine("==============================================");

// {{## BEGIN multicast-delegate-usage ##}}
void Log(string message) { Console.WriteLine($"LOG: {message}"); }
void Note(string msg) { Console.WriteLine($"NOTE: {msg}"); }
gd += Log;
gd += Note;
gd("Greetings, again!");

GreetingDelegate gd2 = (GreetingDelegate)Delegate.Combine((GreetingDelegate)Log, (GreetingDelegate)Note);
GreetingDelegate gd3 = (GreetingDelegate)Delegate.Combine(new GreetingDelegate[] {Log, Note});
GreetingDelegate gd123 = (GreetingDelegate)Delegate.Combine(gd, gd2, gd3);
gd123("Invoke them all, ALL OF THEM!");
// {{## END multicast-delegate-usage ##}}

Console.WriteLine("==============================================");

// {{## BEGIN delegate-literal ##}}
GreetingDelegate gd4 = delegate(string message) { Console.WriteLine($"{message}"); };
gd4("Yet another hello");

string prefix = "PREFIX";
GreetingDelegate gd5 = delegate(string msg) { Console.WriteLine($"{prefix}: {msg}"); };
gd5("<-- Is it PREFIX or is it CHANGED?");
prefix = "CHANGED";
gd5("<-- Is it PREFIX or is it CHANGED?");
// {{## END delegate-literal ##}}

Console.WriteLine("==============================================");

// {{## BEGIN action-and-func ##}}
Action<string> action = delegate (string message) { Console.WriteLine($"I say, {message}!"); };
Func<string, string> func = delegate (string name) { return $"Hello, {name}!"; };
action(func("world"));
// {{## END action-and-func ##}}

Console.WriteLine("==============================================");

// {{## BEGIN lambda-syntax ##}}
var action2 = (string message) => Console.WriteLine($"I say, {message}!");
var func2 = (string name) => $"Hello, {name}!";

action2(func2("world"));
// {{## END lambda-syntax ##}}

Console.WriteLine("==============================================");

// {{## BEGIN functional ##}}
var people = new [] { 
    new Person("Ted", "Neward", 39), 
    new Person("Charlotte", "Neward", 29),
    new Person("Michael", "Neward", 33),
    new Person("Matthew", "Neward", 26)
};
var firstNames = Functional.FoldLeft(people, "", 
    (s, p) => s + " " + p.FirstName);
Console.WriteLine(firstNames);
// {{## END functional ##}}

Console.WriteLine("==============================================");

// {{## BEGIN fn-xml ##}}
Console.WriteLine(Functional.FoldLeft(people, "[",
    (s, p) => s + PersonConverter.ToJSON(p)) + "]");
Console.WriteLine(Functional.FoldLeft(people, "<people>",
    (s, p) => s + PersonConverter.ToXML(p)) + "</people>");
// {{## END fn-xml ##}}

Console.WriteLine("==============================================");

// This must come at the end since it's a type definition, and those
// have to be after any top-level statements in a toplevel-statements file.
//
// {{## BEGIN delegate-declaration ##}}
delegate void GreetingDelegate(string name);
// {{## END delegate-declaration ##}}

