List<Artifact> artifacts = new List<Artifact>();

Artifact artifact1 = new Artifact("John Cleese", "Britain", 20);
Artifact artifact2 = new Artifact("Leonhard Euler", "Switzerland", 3);
Artifact artifact3 = new Artifact("A mouldy burrito", "Between the couch cusions", 99);
Artifact artifact4 = new Artifact("Shoshoni arrowhead", "A pigpen in Ohio", 14);

artifacts.Add(artifact1);
artifacts.Add(artifact2);
artifacts.Add(artifact3);
artifacts.Add(artifact4);


Console.WriteLine($"Artifact count: {artifacts.Count}");
foreach(Artifact artifact in artifacts)
{
    Console.WriteLine("Name: " + artifact.Name);
    Console.WriteLine("Origin: " + artifact.Origin);
    Console.WriteLine("Risk: " + artifact.Risk);
}

artifacts.Add(new Artifact("Pterodactyl bone", "Bavaria, Modern day Germany", 10));
Console.WriteLine($"Artifact count: {artifacts.Count}");

