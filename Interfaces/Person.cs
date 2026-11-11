// {{## BEGIN basic-usage ##}}
public class Person(string FirstName, string LastName) : INameable
{
    public string Name { get; private set; } = FirstName + " " + LastName;

    public void ChangeName(string newName) {
        Name = newName;
        OnNameChanged(newName);
    }
    public event Action<string> OnNameChanged;
}
// {{## END basic-usage ##}}

// {{## BEGIN default-impl-usage ##}}
public class MoreFormalPerson(string FirstName, string LastName, 
    string? MiddleName = null) : IFormalNameable
{
    public string FirstName { get; private set; } = FirstName;
    public string? MiddleName { get; private set; } = MiddleName;
    public string LastName { get; private set; } = LastName;

    public string FormalName => $"{LastName}, {FirstName} {MiddleName ?? ""}";
}
// {{## END default-impl-usage ##}}
