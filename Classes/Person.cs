/*
// {{## BEGIN legacy ##}}
class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;

    public Person(string firstName, string lastName, int age)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
    }
    public Person()
    {
        _firstName = "";
        _lastName = "";
        _age = -1;
    }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public override string ToString()
    {
        return $"{_firstName} {_lastName}, Age: {_age}";
    }
}
// {{## END legacy ##}}
*/

// {{## BEGIN modern ##}}
public class Person(string firstName, string lastName, int age)
{
    public Person() : this("", "", -1) { }

    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public int Age { get; init; } = age;

    public override string ToString() => $"{FirstName} {LastName}, Age: {Age}";
}
// {{## END modern ##}}
