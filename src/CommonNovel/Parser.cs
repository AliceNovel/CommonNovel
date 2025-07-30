namespace CommonNovel;

public static class Tokenizer
{
    public static string[] Tokenize(string input)
    {
        return [];
    }
}

public static class Parser
{
    public static string[] Parse(string input)
    {
        // Use the Tokenizer to split the input into tokens
        return Tokenizer.Tokenize(input);
    }
}
