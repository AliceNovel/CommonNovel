using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace CommonNovel.Benchmarks;

public class Program
{
    public static void Main(string[] args)
        => BenchmarkRunner.Run<Benchmarks>();
}

[MemoryDiagnoser]
public class Benchmarks
{
    [Benchmark]
    public void RunNoder()
    {
        string input =
        """
        - Alice
        [Hi, Bob!]

        - Bob
        [Alice!]

        """;

        _ = Compiler.Noder(input);
    }

    [Benchmark]
    public void RunParser()
    {
        string inputNode =
        """
        - Alice
        [Hi, there.]
        """;

        _ = Compiler.Parse(inputNode);
    }

    [Benchmark]
    public void RunExecutor()
    {
        string[] inputAST = ["CharacterName", "Alice"];

        _ = Compiler.Executor(inputAST);
    }
}
