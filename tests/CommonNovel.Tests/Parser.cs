namespace CommonNovel.Tests;

public class ParserUnitTest
{
    [Fact]
    public void TestStringParser()
    {
        // Arrange
        string input =
        """
        - Alice
        [Hi, Bob!]

        - Bob
        [Alice!]

        """;

        string[] expectedTokens =
        [
            """
            - Alice
            [Hi, Bob!]
            """,
            """
            - Bob
            [Alice!]
            """
        ];

        // Act
        // var tokens = Tokenizer.Tokenize(input);

        // Assert
        // Assert.Equal(expectedTokens.Length, tokens.Length);
        // for (int i = 0; i < expectedTokens.Length; i++)
        // {
        //     Assert.Equal(expectedTokens[i], tokens[i]);
        // }
    }

    [Fact]
    public void TestNodeParser()
    {
        // Arrange
        string input =
        """
        - Alice
        [Hi, there.]
        """;

        string[] expectedTokens =
        [
            "- Alice",
            "[Hi, there.]"
        ];

        // Act
        // var tokens = Tokenizer.Tokenize(input);

        // Assert
        // Assert.Equal(expectedTokens.Length, tokens.Length);
        // for (int i = 0; i < expectedTokens.Length; i++)
        // {
        //     Assert.Equal(expectedTokens[i], tokens[i]);
        // }
    }

    [Theory]
    [InlineData("- Alice", new[] { "- ", "Alice" })]
    public void TestLineTokenizer(string input, string[] expected)
    {
        // Act
        // var tokens = Tokenizer.Tokenize(input);

        // Assert
        // Assert.Single(tokens);
        // Assert.Equal(expected, tokens[0]);
    }
}
