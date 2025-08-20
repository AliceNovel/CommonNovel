# CommonNovel Sample

## The way to process

1. Code → Nodes (Noder)
2. Node → AST (Parser)
3. AST → NovelIL (Emitter)[^out-of-support]

4. (AST → Processing)
5. (NovelIL → Processing)[^out-of-support]

[^out-of-support]: The functions are out of support at this repo. It will supported at NovelIL repo.

```mermaid
graph LR
  Code -- Noder --> Nodes
  Nodes --- Node1[Node]
  Nodes --- Node2[Node]
  Nodes --- Node3[Node]

  Node1 -- Parser --> AST1[AST]
  Node2 -- Parser --> AST2[AST]
  Node3 -- Parser --> AST3[AST]

  AST1 -- Emitter --> NovelIL
  AST2 -- Emitter --> NovelIL
  AST3 -- Emitter --> NovelIL

  AST1 -. Executor .-> Processing1[Processing]
  AST2 -. Executor .-> Processing1
  AST3 -. Executor .-> Processing1

  NovelIL -- Executor --> Processing2[Processing]
```

## Usage

WIP

<!--
```cs
using CommonNovel;

string[] nodes = Compiler.Noder(args[0]);
string[][] tokens = [];
// string[][][] result = [];

int i = 0;
foreach (string node in nodes)
{
    Array.Resize(ref tokens, i + 1);
    tokens[i] = Compiler.Parse(node);
    i++;
}

// AST([]);
```
-->
