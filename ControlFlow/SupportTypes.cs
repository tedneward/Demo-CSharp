public abstract record Vehicle(string Name);
public record Car(string Make, string Model) : Vehicle(Make + " " + Model);
public record Truck(string Make, string Model) : Vehicle(Make + " " + Model);

public record Point(int X, int Y);
