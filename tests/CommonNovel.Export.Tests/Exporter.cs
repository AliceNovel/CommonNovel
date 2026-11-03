using System.Diagnostics.CodeAnalysis;

namespace CommonNovel.Export.Tests;

public class ExporterTest
{
    [Fact]
    public void NIL_Validation()
    {
    }

    [ExcludeFromCodeCoverage]
    public static IEnumerable<object[]> ExporterTestData =>
        [
            // Ex4.1
            [
                "[Hi!]",
                """
                {
                  "cells": [
                    {
                      "messages": "text"
                    }
                  ]
                }
                """
            ],
        ];
}
