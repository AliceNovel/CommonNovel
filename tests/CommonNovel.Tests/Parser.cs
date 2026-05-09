namespace CommonNovel.Tests;

public partial class CompilerUnitTest
{
    [Theory]
    [MemberData(nameof(ParserTestData))]
    public void TestParser(string inputNode, string[][] expectedAST)
    {
        // Act
        string[][] ast = Compiler.Parse(inputNode);

        // Assert
        Assert.Equal(expectedAST.Length, ast.Length);
        for (int i = 0; i < expectedAST.Length; i++)
        {
            for (int j = 0; j < expectedAST[i].Length; j++)
            {
                Assert.Equal(expectedAST[i][j], ast[i][j]);
            }
        }
    }

    public static IEnumerable<object[]> ParserTestData =>
        new List<object[]>
        {
            new object[] // CRLF
            {
                "- Alice\r\n[Hi, there.]",
                (string[][])[
                    ["CharacterName", "Alice"],
                    ["Messages", "Hi, there."]
                ]
            },
            new object[] // LR
            {
                "- Alice\n[Hi, there.]",
                (string[][])[
                    ["CharacterName", "Alice"],
                    ["Messages", "Hi, there."]
                ]
            },
            // new object[] // Example3
            // {
            //     "- Alice\r\n[Hi, there.]\r\n[Welcome!]",
            //     (string[][])[
            //         ["CharacterName", "Alice"],
            //         ["Messages", "Welcome!"]
            //     ]
            // }
        };

    [Theory]
    [InlineData("- Alice", new[] { "CharacterName", "Alice" })]
    [InlineData("[Hi, there.]", new[] { "Messages", "Hi, there." })]
    public void TestParserPatern(string input, string[] expected)
    {
        // Act
        string[][] ast = Compiler.Parse(input);

        // Assert
        Assert.Equal(expected, ast[0]);
    }
}
