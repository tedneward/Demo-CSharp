Console.WriteLine("Hello, Delegates!");

// {{## BEGIN delegate-usage ##}}
GreetingDelegate gd = null;
gd += Console.WriteLine; // this WILL trigger a CS8600 warning about null literal use
gd("Greetings, from a delegate!");
// {{## END delegate-usage ##}}

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

// {{## BEGIN delegate-literal ##}}
GreetingDelegate gd4 = delegate(string message) { Console.WriteLine($"{message}"); };
gd4("Yet another hello");

string prefix = "PREFIX";
GreetingDelegate gd5 = delegate(string msg) { Console.WriteLine($"{prefix}: {msg}"); };
prefix = "CHANGED";
gd5("<-- Is it PREFIX or is it CHANGED?");
// {{## END delegate-literal ##}}

// {{## BEGIN action-and-func ##}}
Action<string> action = delegate (string name) { Console.WriteLine($"I say, {name}!"); };
Func<string, string> func = delegate (string name) { return $"Hello, {name}!"; };
action(func("world"));
// {{## END action-and-func ##}}

// {{## BEGIN delegate-declaration ##}}
delegate void GreetingDelegate(string name);
// {{## END delegate-declaration ##}}

