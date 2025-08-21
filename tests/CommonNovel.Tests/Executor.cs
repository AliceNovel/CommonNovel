namespace CommonNovel.Tests;

public partial class CompilerUnitTest
{
    [Theory]
    [InlineData(new[] { "CharacterName", "Alice" }, "Alice")]
    [InlineData(new[] { "Messages", "Hi!" }, "  \"Hi!\"")]
    [InlineData(new[] { "Example", "Error" }, "")]
    public void TestExecutor(string[] inputAST, string expectedOutput)
    {
        // Act
        string output = Compiler.Executor(inputAST);

        // Assert
        Assert.Equal(expectedOutput, output);
    }
}
