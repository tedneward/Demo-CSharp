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