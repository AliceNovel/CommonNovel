namespace CommonNovel.Tests;

public partial class CompilerUnitTest
{
    [Fact]
    public void TestAST()
    {
        // Arrange
        string[] inputTokens =
        [
            "- ",
            "Alice",
            "[",
            "Hi, there.",
            "]"
        ];

        // [<type>, <arg1>, ({arg2}, ...)]
        string[][] expectedAST =
        [
            ["CharacterName", "Alice"],
            ["Message", "Hi, there."]
        ];

        // Act

        // Assert
    }

    // This is an example for deplication of same command
    [Fact]
    public void TestAST_Ex3()
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
