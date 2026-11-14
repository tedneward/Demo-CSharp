using System.IO;

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

using System.Collections;
using System.Collections.Generic;

// {{## BEGIN line-enumerable ##}}
public sealed class LineEnumerable(string f) : IEnumerable<string>
{
    private readonly string filename = f;

    public IEnumerator<string> GetEnumerator() => new LineEnumerator(f);

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
// {{## END line-enumerable ##}}

// {{## BEGIN file-iterator-1 ##}}
public sealed class LineEnumerator(string fn) : IEnumerator<string>
{
    private readonly StreamReader reader = new StreamReader(fn);
    private string? current;
// {{## END file-iterator-1 ##}}

// {{## END file-iterator-2 ##}}
    public string Current => 
        current ?? throw new InvalidOperationException();

    object IEnumerator.Current => Current;

    public bool MoveNext()
    {
        current = reader.ReadLine();
        return current != null;
    }

    public void Reset()
    {
        throw new NotSupportedException();
    }
// {{## END file-iterator-2 ##}}

// {{## END file-iterator-3 ##}}
    public void Dispose()
    {
        reader.Dispose();
    }
}
// {{## END file-iterator-3 ##}}
