# pas2-csharp-roman-numerals

Convert canonical Roman numerals in the range 1 to 3999.

Part of **Pas2 Polyglot** by [1Pas2](https://github.com/1Pas2): independent small projects in PHP, Python, Go and C#. No runtime dependencies outside the language standard library. Initial version: 0.1.0.

## Requirements and installation

.NET SDK 10 / net10.0. Add a project reference to `src/Library.csproj` from your application. Optional packaging: `dotnet pack src/Library.csproj -c Release`. NuGet publication was not performed.

## Example

```csharp
using Pas2.RomanNumerals;

Console.WriteLine(Roman.Format(2026));
Console.WriteLine(Roman.Parse("MMXXVI"));
```

## API and limits

Roman.Format(value) and Roman.Parse(text) support canonical uppercase numerals 1..3999. Parsing rejects non-canonical subtractive forms, lowercase and empty strings. No overbar notation or historical numeral variants.

## Tests and example

From the repository root:

```sh
dotnet build src/Library.csproj -c Release
dotnet run --project tests/Tests.csproj -c Release
dotnet run --project examples/Examples.csproj -c Release
```

Tests use the standard library or a dependency-free executable check harness. A failing assertion exits nonzero. The example is self-contained and uses local in-memory or temporary data. CI runs the same checks on Linux. No registry releases, downloads, users or production deployments are claimed.

## Contributing

Open a focused issue or pull request with reproduction steps and a behavioral test. Run the commands above before submitting. Do not include credentials or private data in reports.

## Ecosystem

[Browse Pas2 projects](https://github.com/1Pas2?tab=repositories&q=pas2-). Each repository is usable independently. The earlier TypeScript series and this polyglot series have distinct repository names.

## License

[MIT](LICENSE) © 2026 1Pas2.

1Pas2
