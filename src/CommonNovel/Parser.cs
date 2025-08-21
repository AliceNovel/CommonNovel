using System.Text.RegularExpressions;

namespace CommonNovel;

public partial class Compiler
{
    /// <summary>
    /// CommonNovel Node to AST
    /// </summary>
    /// <param name="node">CommonNovel Node</param>
    /// <returns>AST</returns>
    public static string[][] Parse(string node)
    {
        string[][] ast = [];

        node = node.Replace("\r", "").Replace("\n", ""); // remove CR and LF codes

        string[] keywords = [
            "- ", "[", "]"
        ];

        string pattern = string.Join("|", keywords.Select(Regex.Escape));
        string regex = $"({pattern})";

        string[] parts = Regex.Split(node, regex);

        for (int i = 0; i < parts.Length; i++)
        {
            parts[i] = parts[i].Trim(); // format

            if (parts[i] == "-")
            {
                Array.Resize(ref ast, ast.Length + 1);
                Array.Resize(ref ast[^1], 2);

                ast[^1][0] = "CharacterName";
                ast[^1][1] = parts[i + 1];
            }

            if (parts[i] == "[")
            {
                i++;
                int endMessages = i;
                for (int j = i; parts[endMessages] != "]"; j++)
                {
                    endMessages = j;
                }
                string messages = string.Join("", parts[i..endMessages]);

                Array.Resize(ref ast, ast.Length + 1);
                Array.Resize(ref ast[^1], 2);

                ast[^1][0] = "Messages";
                ast[^1][1] = messages;
            }
        }

        return ast;
    }
}
