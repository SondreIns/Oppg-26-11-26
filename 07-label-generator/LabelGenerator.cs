public class LabelGenerator
{
    public string CreateLabel(string rawText) => Normalize(rawText);

    private string Normalize(string rawText) => "LABEL: " + rawText.Trim(' ').ToUpper();
}
