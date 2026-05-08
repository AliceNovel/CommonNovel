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
    private readonly string _input =
        """
        - Alice
        [Hi, Bob!]

        - Bob
        [Alice!]

        """;

    private readonly string _inputNode =
        """
        - Alice
        [Hi, there.]
        """;

    private readonly string[] _inputAST = ["CharacterName", "Alice"];

    [Benchmark]
    public void RunNoder() => _ = Compiler.Noder(_input);

    [Benchmark]
    public void RunParser() => _ = Compiler.Parse(_inputNode);

    [Benchmark]
    public void RunExecutor() => _ = Compiler.Executor(_inputAST);
}
