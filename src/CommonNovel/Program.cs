namespace CommonNovel;

public partial class Compiler
{
    public static void Main(string[] args)
    {
        string[] nodes = Noder(args[0]);
        string[][] tokens = [];
        // string[][][] result = [];

        int i = 0;
        foreach (string node in nodes)
        {
            Array.Resize(ref tokens, i + 1);
            tokens[i] = Parse(node);
            i++;
        }

        // AST([]);
    }   
}
