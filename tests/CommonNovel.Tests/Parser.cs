namespace CommonNovel.Tests;

public partial class CompilerUnitTest
{
    [Fact]
    public void TestParser()
    {
        // Arrange
        string inputNode =
        """
        - Alice
        [Hi, there.]
        """;

        // [<type>, <arg>]
        string[][] expectedAST =
        [
            ["CharacterName", "Alice"],
            ["Messages", "Hi, there."]
        ];

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

    // This is an example for deplication of same command
    [Fact]
    public void TestParser_Ex3()
    {
        // Arrange
        string inputNode =
        """
        - Alice
        [Hi, there.]
        [Welcome!]
        """;

        // [<type>, <arg>]
        string[][] expectedAST =
        [
            ["CharacterName", "Alice"],
            ["Messages", "Welcome!"]
        ];

        // Act
        string[][] ast = Compiler.Parse(inputNode);

        // Assert
        // Assert.Equal(expectedAST.Length, ast.Length);
        // for (int i = 0; i < expectedAST.Length; i++)
        // {
        //     Assert.Equal(expectedAST[i], ast[i]);
        // }
    }

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
