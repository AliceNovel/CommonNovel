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
        ReadOnlySpan<char> inputSpan = input.AsSpan();
        List<string> nodeList = [];

        int start = 0;
        for (int i = 0; i < inputSpan.Length; i++)
        {
            int? end = null;
            if (inputSpan[i] != '\n') continue;

            // "\n\n" (LF) or "\r\n\r\n" (CRLF), "\n  \t\n" (tabs, spaces) => Split
            for (int j = i + 1; j < inputSpan.Length; j++)
            {
                if (inputSpan[j] == '\n')
                {
                    end = j + 1;
                    break;
                }
                if (char.IsWhiteSpace(inputSpan[j]) || (inputSpan[i] == '\r'))
                    continue;
                else
                    break;
            }

            if (end is null) continue;

            ReadOnlySpan<char> node = inputSpan[start..end.Value].TrimEnd(['\r', '\n']);
            nodeList.Add(node.ToString());

            start = end.Value;
        }

        if (start < inputSpan.Length)
            nodeList.Add(inputSpan[start..].TrimEnd(['\r', '\n']).ToString());

        return nodeList.ToArray();
    }
}
