namespace CommonNovel.Tests;

public class TokenizerUnitTest
{
    [Fact]
    public void TestNoder()
    {
        // Arrange
        string inputCommonNovel =
        """
        - Alice
        [Hi, Bob!]

        - Bob
        [Alice!]

        """;

        string[] expectedNodes =
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
        // string[] nodes = Tokenizer.Tokenize(input);

        // Assert
        // Assert.Equal(expectedNodes.Length, nodes.Length);
        // for (int i = 0; i < expectedNodes.Length; i++)
        // {
        //     Assert.Equal(expectedNodes[i], nodes[i]);
        // }
    }
}
