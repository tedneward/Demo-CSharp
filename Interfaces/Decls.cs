// {{## BEGIN basic ##}}
interface INameable
{
    string Name { get; }

    void ChangeName(string newName);
    event Action<string> OnNameChanged;
}
// {{## END basic ##}}

// {{## BEGIN eimd-declaration ##}}
interface ICowboy : INameable
{
    void Draw();
    void Reload();
}
interface IArtist : INameable
{
    void Draw();
    void Restock();
}
// {{## END eimd-declaration ##}}

// {{## BEGIN default-impl ##}}
interface IFormalNameable
{
    string FirstName { get; }
    string? MiddleName { get; }
    string LastName { get; }

    string GetFullName() { return $"{FirstName} {LastName}"; }
    string FormalName => $"{LastName}, {FirstName} {MiddleName ?? ""}";
}
// {{## END default-impl ##}}

interface ISequential<T> where T : ISequential<T>
{
    static abstract T operator ++(T other);
}

public struct RepeatChar : ISequential<RepeatChar>
{
    private const char Ch = 'A';
    public string Text = new string(Ch, 1);

    public RepeatChar() {}

    public static RepeatChar operator ++(RepeatChar other)
        => other with { Text = other.Text + Ch };

    public override string ToString() => Text;
}

interface ICurrency
{
    string Name { get; }
    char Symbol { get; }
    int FaceValue { get; }

    static abstract ICurrency operator +(ICurrency lhs, ICurrency rhs);
    static abstract ICurrency operator -(ICurrency lhs, ICurrency rhs);
}