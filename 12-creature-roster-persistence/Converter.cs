public static class Converter
{
    // ToCreature for fleire objekter
    public static List<Creature> ConvertAllToCreature(string[] input)
    {
        List<Creature> result = new();
        foreach(string item in input)
        {
            Creature creature = ToCreature(item);
            result.Add(creature);
        }
        return result;
    }

    // ToText for fleire objecter
    public static string[] ConvertAllToText(List<Creature> input)
    {
        List<string> result = new();
        foreach(Creature creature in input)
        {
            result.Add(ToText(creature));
        }
        return result.ToArray();
    }

    // Konverter string i fil til Creature object
    private static Creature ToCreature(string input)
    {
        string[] result = input.Split('|');
        if(!int.TryParse(result[2], out int energy)) energy = 0;
        return new Creature(result[0], result[1], energy);
    }

    // Konverter Creature object til string for lagrings
    private static string ToText(Creature input)
    {
        return $"{input.Name}|{input.Species}|{input.Energy}";
    }
}