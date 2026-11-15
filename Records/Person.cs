
// {{## BEGIN simple ##}}
public record Person(string FirstName, string LastName, int Age);
// {{## END simple ##}}

// {{## BEGIN inheritance ##}}
public record Student(string FirstName, string LastName, int Age, int GradeLevel)
    : Person(FirstName, LastName, Age);
// {{## END inheritances ##}}
