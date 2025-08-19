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

        string[] expectedTokens =
        [
            "- ",
            "Alice",
            "[",
            "Hi, there.",
            "]"
        ];

        // Act
        string[] parse = Compiler.Parse(inputNode);

        // Assert
        Assert.Equal(expectedTokens.Length, parse.Length);
        for (int i = 0; i < expectedTokens.Length; i++)
        {
            Assert.Equal(expectedTokens[i], parse[i]);
        }
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
}
