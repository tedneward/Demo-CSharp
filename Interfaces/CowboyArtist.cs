// {{## BEGIN eimd-cowboy ##}}
public class Cowboy(string Name) : ICowboy
{
    public string Name { get; private set; } = Name;
    public void ChangeName(string newName) { Name = newName; OnNameChanged(newName); }
    public event Action<string> OnNameChanged = (n) => { };

    public void Draw() { Console.WriteLine($"{Name}: BANG BANG"); }
    public void Reload() { Console.WriteLine($"{Name}: Reloading..."); }
}
// {{## END eimd-cowboy ##}}

// {{## BEGIN eimd-artist ##}}
public class Artist(string Name) : IArtist
{
    public string Name { get; private set; } = Name;
    public void ChangeName(string newName) { Name = newName; OnNameChanged(newName); }
    public event Action<string> OnNameChanged = (n) => { };

    public void Draw() { Console.WriteLine($"{Name}: A lovely piece"); }
    public void Restock() { Console.WriteLine($"{Name}: Opening new paints..."); }
}
// {{## END eimd-artist ##}}

// {{## BEGIN eimd-cowboyartist ##}}
public class CowboyArtist(string Name) : IArtist, ICowboy
{
    // We get the INameable contract through both IArtist and ICowboy
    public string Name { get; private set; } = Name;
    public void ChangeName(string newName) { Name = newName; OnNameChanged(newName); }
    public event Action<string> OnNameChanged = (n) => { };

    public void Reload() { Console.WriteLine($"{Name}: Reloading..."); }
    public void Restock() { Console.WriteLine($"{Name}: Opening new paints..."); }

    void IArtist.Draw() { Console.WriteLine($"{Name}: A lovely piece"); }
    void ICowboy.Draw() { Console.WriteLine($"{Name}: BANG BANG"); }
}
// {{## END eimd-cowboyartist ##}}