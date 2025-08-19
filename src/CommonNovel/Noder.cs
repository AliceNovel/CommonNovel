namespace CommonNovel;

public partial class Compiler
{
    /// <summary>
    /// CommonNovel Scripts to Nodes
    /// </summary>
    /// <param name="input">CommonNovel Scripts</param>
    /// <returns>Nodes</returns>
    public static string[] Noder(string input)
    {
        string[] lines = [];
        string[] nodes = [];

        using (StringReader reader = new(input))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                lines = [.. lines, line];
            }
        }

        int i = 0;
        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                i++;
                continue;
            }

            Array.Resize(ref nodes, i + 1);
            if (string.IsNullOrWhiteSpace(nodes[i]))
                nodes[i] = line;
            else
                nodes[i] += Environment.NewLine + line;
        }

        return nodes;
    }
}
