namespace CommonNovel;

public partial class Compiler
{
    public static string Emitter(string[][] input)
    {
        foreach (string[] ast in input)
        {
            string command = ast[0];
            string arg = ast[1];

            switch (command)
            {
                case "CharacterName":
                case "character-name":
                    // Processing
                    break;

                case "Message":
                case "Messages":
                case "messages":
                    // Processing
                    break;

                default:
                    Console.WriteLine("This command is out of support.");
                    break;
            }
        }

        return "";
    }
}
