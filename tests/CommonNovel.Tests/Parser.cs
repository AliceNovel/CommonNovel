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

        // [<type>, <arg1>, ({arg2}, ...)]
        string[][] expectedAST =
        [
            ["CharacterName", "Alice"],
            ["Message", "Hi, there."]
        ];

        // Act
        // string[][] parse = Compiler.Parse(inputNode);

        // Assert
        // Assert.Equal(expectedAST.Length, parse.Length);
        // for (int i = 0; i < expectedAST.Length; i++)
        // {
        //     Assert.Equal(expectedAST[i], parse[i]);
        // }
    }

    [Theory]
    [InlineData("- Alice", new[] { "CharacterName", "Alice" })]
    [InlineData("[Hi, there.]", new[] { "Message", "Hi, there." })]
    public void TestParserPatern(string input, string[] expected)
    {
        // Act
        // string[][] parse = Compiler.Parse(input);

        // Assert
        // Assert.Single(parse);
        // Assert.Equal(expected, parse[0]);
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

        // [<type>, <arg1>, ({arg2}, ...)]
        string[][] expectedAST =
        [
            ["CharacterName", "Alice"],
            ["Message", "Welcome!"]
        ];

        // Act
        // string[][] parse = Compiler.Parse(inputNode);

        // Assert
        // Assert.Equal(expectedAST.Length, parse.Length);
        // for (int i = 0; i < expectedAST.Length; i++)
        // {
        //     Assert.Equal(expectedAST[i], parse[i]);
        // }
    }
}
