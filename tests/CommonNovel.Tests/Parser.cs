namespace CommonNovel.Tests;

public class ParserUnitTest
{
    [Fact]
    public void TestTokenizer()
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
        var tokens = Tokenizer.Tokenize(input);

        // Assert
        Assert.Equal(expectedTokens.Length, tokens.Length);
        for (int i = 0; i < expectedTokens.Length; i++)
        {
            Assert.Equal(expectedTokens[i], tokens[i]);
        }
    }
}
