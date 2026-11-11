global using Both = (double, int); // Both == pair of double, int

Console.WriteLine("(Hello), (World)!");

// {{## BEGIN defining ##}}
var t1 = (4.5, 3); // pair of double,int

var t2 = (Sum: 4.5, Count: 3); // pair of double, int
Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");

(double Sum, int Count) t3 = (4.5, 3); // pair of double, int
Console.WriteLine($"Sum of {t3.Count} elements is {t3.Sum}.");

//global using Both = (double, int); // Both == pair of double, int
Both t4 = (4.5, 3);
Both t5 = t1;
// {{## END defining ##}}

// {{## BEGIN accessing ##}}
// Assuming t1, t2, ... t5 from before....
// Deconstruction on declaration
(double d1, int i1) = t1;
// Access via names (if provided in tuple declaration)
double d2 = t2.Sum; int i2 = t2.Count;
// Another form of deconstruction, inferring types
var (d3, i3) = t3;
// Partial-inference deconstruction
(var d4, int i4) = t4;
(double d5, var i5) = t5;
// {{## END accessing ##}}

// {{## BEGIN equality ##}}
Console.WriteLine($"{t1} == {t2}? {t1 == t2}");
Console.WriteLine($"{t1} == {t3}? {t1 == t3}");
Console.WriteLine($"{t1} == {t4}? {t1 == t4}");
Console.WriteLine($"{t1} == {t2}? {t1 == t5}");
var t6 = (3, 4.5);
Console.WriteLine($"{t1} == {t6}? {t1 == t6}");
Console.WriteLine($"{t1} == (3, 4.5)? {t1 == (3, 4.5)}");
var t7 = (3, 4.5, "Fred");
//Console.WriteLine($"{t1} == {t7}? {t1 == t7}"); // Error!
// {{## END equality ##}}