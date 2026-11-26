string path = "blackbox.txt";
string[] exampleData = ["An argument is an intellectual process to establish a definite propostion. It isn't just saying \"No it isn't\".", "Yes it is.", "No it isn't!"];

if(!File.Exists(path))
{
    Console.WriteLine("File not found. Generating.");
    File.WriteAllLines(path, exampleData);
}

string[] data = File.ReadAllLines(path);
foreach(string item in data)
{
    Console.WriteLine(item);
}


