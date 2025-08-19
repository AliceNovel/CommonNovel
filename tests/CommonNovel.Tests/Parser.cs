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

    // [Theory]
    // [InlineData("- Alice", new[] { "- ", "Alice" })]
    // public void TestParserPatern(string input, string[] expected)
    // {
    //     // Act
    //     // var tokens = Tokenizer.Tokenize(input);

    //     // Assert
    //     // Assert.Single(tokens);
    //     // Assert.Equal(expected, tokens[0]);
    // }

    // This is an example for deplication of same command
    [Fact]
    public void TestParser_Ex3()
    {
        // Arrange
        string[] inputTokens =
        [
            "- ",
            "Alice",
            "[",
            "Hi, there.",
            "]",
            "[",
            "Welcome!",
            "]"
        ];

        // [<type>, <arg1>, ({arg2}, ...)]
        string[][] expectedAST =
        [
            ["CharacterName", "Alice"],
            ["Message", "Welcome!"]
        ];

        // Act

        // Assert
    }
}
