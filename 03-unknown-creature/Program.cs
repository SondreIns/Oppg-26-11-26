// Gjort det på tre forskjellege måtar berre fordi
Creature first = new Creature()
{
    Name = "Bob Mortimer",
    Species = "Human",
    Energy = 101
};

Creature second = new Creature("Jake", "Bird", 18);

Creature third = new Creature();
third.Name = "Polly";
third.Species = "Norwegian Blue";
third.Energy = 0;

// Har override ToString i creature klassen
Console.WriteLine(first);
Console.WriteLine(second);
Console.WriteLine($"{third.Name}, a {third.Species} Parrot, which has {third.Energy} energy because it's resting. Lovely plumage");
