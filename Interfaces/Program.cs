Console.WriteLine("Hello, IWorld!");

// {{## BEGIN basic-usage ##}}
var p = new Person("Charlotte", "Donat");
Console.WriteLine(p.Name);

p.OnNameChanged += (newName) => Console.WriteLine("Name is now " + newName);
p.ChangeName("Charlotte Neward");
// {{## END basic-usage ##}}

// {{## BEGIN eimd-usage ##}}
void Shootout(ICowboy gf1, ICowboy gf2) {
    gf1.Draw(); gf1.Reload();
    gf2.Draw(); gf2.Reload();
}
void GalleryOpening(IArtist a) {
    a.Draw(); a.Restock();
}
Cowboy bill = new Cowboy("Buffalo Bill");
Cowboy cody = new Cowboy("Wild West");
Shootout(bill, cody);
Artist bob = new Artist("Bob Ross");
GalleryOpening(bob);
// {{## END eimd-usage ##}}

// {{## BEGIN eimd-problem ##}}
CowboyArtist ca = new CowboyArtist("Charles M Russell"); // real dude
// {{## END eimd-problem ##}}
Shootout(ca, cody);
GalleryOpening(ca);

// {{## BEGIN default-impl-usage ##}}
MoreFormalPerson mfp = new("Ted", "Neward");
Console.WriteLine($"{mfp.FormalName}");
Console.WriteLine($"{((IFormalNameable)mfp).GetFullName()}");
// {{## END default-impl-usage ##}}

var rc = new RepeatChar();
for (int i = 0; i < 10; i++)
    Console.WriteLine(rc++);

