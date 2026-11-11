public record Person(string FirstName, string LastName, int Age);

public class PersonConverter
{
    public static string ToJSON(Person p) {
        return $"{{ firstName:'{p.FirstName}', lastName:'{p.LastName}', age:'{p.Age}' }},";
    }
    public static string ToXML(Person p) {
        return $"<person firstName='{p.FirstName}' lastName='{p.LastName}' age='{p.Age}' />";
    }

}