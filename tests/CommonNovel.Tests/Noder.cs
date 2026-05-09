namespace CommonNovel.Tests;

public partial class CompilerUnitTest
{
    [Theory]
    [MemberData(nameof(NoderTestData))]
    public void TestNoder(string input, string[] expectedNodes)
    {
        // Act
        string[] nodes = Compiler.Noder(input);

        // Assert
        Assert.Equal(expectedNodes.Length, nodes.Length);
        for (int i = 0; i < expectedNodes.Length; i++)
        {
            Assert.Equal(expectedNodes[i], nodes[i]);
        }
    }

    private static readonly string Nl = Environment.NewLine;

    public static IEnumerable<object[]> NoderTestData =>
        new List<object[]>
        {
            new object[] // CRLF
            {
                "- Alice\r\n[Hi, Bob!]\r\n\r\n- Bob\r\n[Alice!]\r\n\r\n",
                (string[])[
                    $"- Alice{Nl}[Hi, Bob!]", // Future -> "\r\n"
                    $"- Bob{Nl}[Alice!]" // Future -> "\r\n"
                ]
            },
            new object[] // LF
            {
                "- Alice\n[Hi, Bob!]\n\n- Bob\n[Alice!]\n\n",
                (string[])[
                    $"- Alice{Nl}[Hi, Bob!]", // Future -> '\n'
                    $"- Bob{Nl}[Alice!]" // Future -> '\n'
                ]
            },
            new object[] // three enters
            {
                "\r\n\r\n\r\n",
                (string[])[] // Future -> [ "", "" ]
            }
        };
}
