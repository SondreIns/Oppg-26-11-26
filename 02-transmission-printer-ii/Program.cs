class Program
{
    static void Main()
    {
        PrintTransmission("System ready");
        PrintTransmission("Dock", "Gate unlocked");
        PrintTransmission("Lemming of the BDA", "Keep your teeth clean", 3);
    }

    static void PrintTransmission(string message)
    {
        Console.WriteLine($"[UNKNOWN] {message}");
    }

    static void PrintTransmission(string sender, string message)
    {
        Console.WriteLine($"[{sender}] {message}");
    }

    static void PrintTransmission(string sender, string message, int numRepeats)
    {
        for(int i = 0; i < numRepeats; i++)
        {
            Console.WriteLine($"[{sender}] {message}");
        }
    }
}