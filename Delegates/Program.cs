Console.WriteLine("Hello, Delegates!");

// {{## BEGIN delegate-usage ##}}
GreetingDelegate gd = null;
gd += Console.WriteLine;
gd("Greetings, from a delegate!");
// {{## END delegate-usage ##}}

// {{## BEGIN multicast-delegate-usage ##}}
void Log(string message) { Console.WriteLine($"LOG: {message}"); }
void Note(string msg) { Console.WriteLine($"NOTE: {msg}"); }
gd += Log;
gd += Note;
gd("Greetings, again!");

GreetingDelegate gd2 = (GreetingDelegate)Delegate.Combine(Log, Note);
GreetingDelegate gd3 = (GreetingDelegate)Delegate.Combine(new [] {Log, Note, Console.WriteLine});
// {{## END multicast-delegate-usage ##}}

// {{## BEGIN delegate-literal ##}}
GreetingDelegate gd4 = delegate(string message) { Console.WriteLine($"{message}"); };
gd4("Yet another hello");
// {{## END delegate-literal 

// {{## BEGIN delegate-declaration ##}}
delegate void GreetingDelegate(string name);
// {{## END delegate-declaration ##}}

