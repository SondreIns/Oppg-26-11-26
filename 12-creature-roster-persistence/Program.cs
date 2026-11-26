string path = "creatures.txt";

List<Creature> creatures = new List<Creature>
{
    new Creature("Mora", "Lumen Fox", 72),
    new Creature("Kip", "Dust Eel", 18),
    new Creature("Senn", "Cloud Moth", 41)
};

// Konverter og skriv
string[] creaturesText = Converter.ConvertAllToText(creatures);
File.WriteAllLines(path, creaturesText);

// Konverter tilbake og les
string[] loadedCreatures = File.ReadAllLines(path);
List<Creature> loadedCreatureObjects = Converter.ConvertAllToCreature(loadedCreatures);
foreach(Creature creature in loadedCreatureObjects)
{
    // Override tostring i creature klassen
    Console.WriteLine(creature);
}
