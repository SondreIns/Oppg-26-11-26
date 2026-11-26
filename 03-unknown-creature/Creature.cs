public class Creature
{
    public string Name { get; set; } = "";
    public string Species { get; set; } = "";
    public int Energy { get; set; }

    public Creature() {}
    public Creature(string name, string species, int energy)
    {
        Name = name;
        Species = species;
        Energy = energy;
    }

    public override string ToString() => $"{Name}, a creature of the {Species} species, with an energy level of {Energy}";
}
