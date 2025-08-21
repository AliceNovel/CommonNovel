namespace CommonNovel;

public partial class Compiler
{
    /// <summary>
    /// Run CommonNovel AST
    /// <code>
    /// // Example
    /// string output = Executor(ast)
    /// Console.WriteLine(output);
    /// </code>
    /// </summary>
    /// <param name="ast">CommonNovel AST</param>
    /// <returns>Output</returns>
    public static string Executor(string[] ast)
    {
        string output;

        switch (ast[0])
        {
            case "CharacterName":
                output = ast[1];
                break;

            case "Messages":
                output = "  \"" + ast[1] + "\"";
                break;

            default:
                output = "";
                Console.Error.WriteLine("[Error] This command is not supported.");
                break;
        }

        return output;
    }
}
