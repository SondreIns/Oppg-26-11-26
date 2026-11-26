public class ArtifactCatalog
{
    private List<Artifact> artifacts = new List<Artifact>();

    public void Add(Artifact artifact)
    {
        artifacts.Add(artifact);
    }

    public void PrintAll()
    {
        // Override tostring i artifact.cs
        foreach(Artifact artifact in artifacts) Console.WriteLine(artifact);
    }

    public Artifact? FindByName(string name)
    {
        foreach (Artifact artifact in artifacts)
        {
            if(artifact.Name == name) return artifact;
        }
        return null;
    }
}
