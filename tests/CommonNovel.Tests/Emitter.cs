namespace CommonNovel.Tests;

public partial class CompilerUnitTest
{
    [Fact]
    public void TestEmitter()
    {
        // Arrange
        string[][] inputAST =
        [
            ["CharacterName", "Alice"],
            ["Message", "Hi, there."]
        ];

        // NovelIL
        string expectedNIL =
        """
        {
          "cells": [
            {
              "character-name": "Alice",
              "messages": "Hi, there.",
              "images": {
                "foreground": "Alice.png"
              }
            }
          ]
        }
        """;

        // Act
        // string nil = Compiler.Emitter(inputAST);

        // Assert
    }
}
