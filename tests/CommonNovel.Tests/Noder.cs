using System.Diagnostics.CodeAnalysis;

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

    [ExcludeFromCodeCoverage]
    public static IEnumerable<object[]> NoderTestData =>
        new List<object[]>
        {
            new object[] // CRLF
            {
                "- Alice\r\n[Hi, Bob!]\r\n\r\n- Bob\r\n[Alice!]\r\n\r\n",
                (string[])[
                    "- Alice\r\n[Hi, Bob!]",
                    "- Bob\r\n[Alice!]"
                ]
            },
            new object[] // LF
            {
                "- Alice\n[Hi, Bob!]\n\n- Bob\n[Alice!]\n\n",
                (string[])[
                    "- Alice\n[Hi, Bob!]",
                    "- Bob\n[Alice!]"
                ]
            },
            new object[] // three enters
            {
                "\r\n\r\n\r\n",
                (string[])[ "", "" ]
            },
            new object[] // single element
            {
                "- Alice",
                (string[])[ "- Alice" ]
            },
            new object[] // spaces and tabs between newline-codes (\n or \r\n)
            {
                "\r\n  \t   \r\n",
                (string[])[ "" ]
            }
        };
}
