namespace CommonNovel.Tests;

public partial class CompilerUnitTest
{
    [Fact]
    public void TestNoder()
    {
        // Arrange
        string input =
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
        string[] nodes = Compiler.Noder(input);

        // Assert
        Assert.Equal(expectedNodes.Length, nodes.Length);
        for (int i = 0; i < expectedNodes.Length; i++)
        {
            Assert.Equal(expectedNodes[i], nodes[i]);
        }
    }
}
