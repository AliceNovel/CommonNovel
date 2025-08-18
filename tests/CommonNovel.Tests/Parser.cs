namespace CommonNovel.Tests;

public class ParserUnitTest
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

        // Assert
    }

    [Theory]
    [InlineData("- Alice", new[] { "- ", "Alice" })]
    public void TestParserPatern(string input, string[] expected)
    {
        // Act
        // var tokens = Tokenizer.Tokenize(input);

        // Assert
        // Assert.Single(tokens);
        // Assert.Equal(expected, tokens[0]);
    }
}
