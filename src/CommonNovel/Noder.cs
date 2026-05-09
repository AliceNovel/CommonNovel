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
            int end;
            if (inputSpan[i] != '\n') continue;

            // "\n\n" (LF) or "\r\n\r\n" (CRLF) => Split
            if (i + 1 < inputSpan.Length
                        && inputSpan[i + 1] == '\n')
                end = i + 2;
            else if (i + 2 < inputSpan.Length
                        && inputSpan[i + 1] == '\r'
                        && inputSpan[i + 2] == '\n')
                end = i + 3;
            else continue;

            ReadOnlySpan<char> node = inputSpan[start..end].TrimEnd(['\r', '\n']);
            nodeList.Add(node.ToString());

            start = end;
        }

        if (start < inputSpan.Length)
            nodeList.Add(inputSpan[start..].TrimEnd(['\r', '\n']).ToString());

        return nodeList.ToArray();
    }
}
