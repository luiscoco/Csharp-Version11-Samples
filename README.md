# C# 11.0 Features (VS 2022 / .NET 7)

This repo contains small, focused projects that demonstrate individual C# 11 features.

## Quick Index
- P172_RawStringLiterals: raw string literals.
- P173_GenericMath: generic math with `INumber<T>`.
- P174_GenericAttributes: generic type parameters in attributes.
- P175_Utf8StringLiterals: UTF-8 string literals (`"text"u8`).
- P176_NewlinesInInterpolation: multiline interpolation expressions.
- P177_ListPatterns: list patterns and slices.
- P178_FileLocalTypes: file-local types via `file`.
- P179_RequiredMembers: `required` properties.
- P180_AutoDefaultStructs: zero-initialized struct fields.
- P181_PatternMatchSpanConstString: match `ReadOnlySpan<char>` against constants.
- P182_ExtendedNameofScope: `nameof` in parameter attributes.
- P183_NumericIntPtr: numeric operators on `IntPtr`.
- P184_RefFieldsAndScopedRef: `ref` fields and `scoped ref` parameters.
- P185_MethodGroupToDelegate: method group to delegate conversion.
- P186_WarningWave7: warning wave 7 via `AnalysisLevel`.

## Projects

### P172_RawStringLiterals
Raw string literals preserve quotes, backslashes, and braces without escaping.
```csharp
var raw = """
    Line 1
    "quotes" and \slashes\
    {braces} stay as-is
    """;
```
Files:
- `P172_RawStringLiterals/Program.cs`: shows raw string literal formatting and output.
- `P172_RawStringLiterals/P168_RawStringLiterals.csproj`: builds the executable for this sample.

### P173_GenericMath
Generic math with `INumber<T>` enables type-agnostic numeric algorithms.
```csharp
static T SumAll<T>(ReadOnlySpan<T> values) where T : INumber<T>
{
    T sum = T.Zero;
    for (int i = 0; i < values.Length; i++)
        sum += values[i];
    return sum;
}
```
Files:
- `P173_GenericMath/Program.cs`: sums ints and doubles via generic math.
- `P173_GenericMath/P169_GenericMath.csproj`: builds the executable for this sample.

### P174_GenericAttributes
Attributes can be declared with generic type parameters.
```csharp
public class ExampleAttribute<T> : Attribute {}

[Example<int>]
class Demo {}
```
Files:
- `P174_GenericAttributes/Program.cs`: defines and applies a generic attribute.
- `P174_GenericAttributes/P170_GenericAttributes.csproj`: builds the executable for this sample.

### P175_Utf8StringLiterals
UTF-8 string literals produce `ReadOnlySpan<byte>` at compile time.
```csharp
ReadOnlySpan<byte> data = "Hola \u263A"u8;
Console.WriteLine(Encoding.UTF8.GetString(data));
```
Files:
- `P175_Utf8StringLiterals/Program.cs`: prints UTF-8 bytes as a string.
- `P175_Utf8StringLiterals/P171_Utf8StringLiterals.csproj`: builds the executable for this sample.

### P176_NewlinesInInterpolation
Newlines are allowed inside interpolation expressions.
```csharp
string s = $"Sum is {
    x
    + 7
}.";
```
Files:
- `P176_NewlinesInInterpolation/Program.cs`: demonstrates multiline interpolation.
- `P176_NewlinesInInterpolation/P172_NewlinesInInterpolation.csproj`: builds the executable for this sample.

### P177_ListPatterns
List patterns match arrays with positions and slices.
```csharp
static string Classify(int[] a) => a switch
{
    [] => "empty",
    [1, 2, ..] => "starts with 1,2",
    [.., 9] => "ends with 9",
    _ => "other"
};
```
Files:
- `P177_ListPatterns/Program.cs`: classifies arrays with list patterns.
- `P177_ListPatterns/P173_ListPatterns.csproj`: builds the executable for this sample.

### P178_FileLocalTypes
The `file` modifier restricts type visibility to the current file.
```csharp
file class Helper { public static string Ping() => "file-local OK"; }
```
Files:
- `P178_FileLocalTypes/Program.cs`: declares and uses a file-local type.
- `P178_FileLocalTypes/P174_FileLocalTypes.csproj`: builds the executable for this sample.

### P179_RequiredMembers
`required` ensures properties are set during initialization.
```csharp
public class Person
{
    public required string Name { get; init; }
    public int Age { get; init; }
}
```
Files:
- `P179_RequiredMembers/Program.cs`: initializes a `required` property.
- `P179_RequiredMembers/P175_RequiredMembers.csproj`: builds the executable for this sample.

### P180_AutoDefaultStructs
Struct fields are automatically zero-initialized on default construction.
```csharp
var m = new Measurements();
Console.WriteLine($"A={m.A}, B={m.B}");
```
Files:
- `P180_AutoDefaultStructs/Program.cs`: prints default field values.
- `P180_AutoDefaultStructs/P176_AutoDefaultStructs.csproj`: builds the executable for this sample.

### P181_PatternMatchSpanConstString
`ReadOnlySpan<char>` can be pattern-matched against constant strings.
```csharp
ReadOnlySpan<char> span = "hello".AsSpan();
if (span is "hello")
    Console.WriteLine("Matched constant string on Span<char>");
```
Files:
- `P181_PatternMatchSpanConstString/Program.cs`: matches a span against a constant string.
- `P181_PatternMatchSpanConstString/P177_PatternMatchSpanConstString.csproj`: builds the executable for this sample.

### P182_ExtendedNameofScope
`nameof` can now reference parameters inside parameter attributes.
```csharp
static void Method([Name(nameof(x))] int x)
{
}
```
Files:
- `P182_ExtendedNameofScope/Program.cs`: uses `nameof` in a parameter attribute.
- `P182_ExtendedNameofScope/P178_ExtendedNameofScope.csproj`: builds the executable for this sample.

### P183_NumericIntPtr
`IntPtr` and `UIntPtr` support numeric operators.
```csharp
IntPtr a = 3;
a += 4;
Console.WriteLine(a > (IntPtr)2);
```
Files:
- `P183_NumericIntPtr/Program.cs`: demonstrates numeric operators on `IntPtr`.
- `P183_NumericIntPtr/P179_NumericIntPtr.csproj`: builds the executable for this sample.

### P184_RefFieldsAndScopedRef
`ref` fields and `scoped ref` parameters improve safety for references.
```csharp
ref struct RefBox
{
    public ref int RefValue;
    public RefBox(ref int r) { RefValue = ref r; }
}
```
Files:
- `P184_RefFieldsAndScopedRef/Program.cs`: uses ref fields and scoped refs.
- `P184_RefFieldsAndScopedRef/P180_RefFieldsAndScopedRef.csproj`: builds the executable for this sample.

### P185_MethodGroupToDelegate
Method group conversions are improved for delegates.
```csharp
static string ToS(int x) => x.ToString();
Func<int, string> f = ToS;
```
Files:
- `P185_MethodGroupToDelegate/Program.cs`: assigns a method group to a delegate.
- `P185_MethodGroupToDelegate/P181_MethodGroupToDelegate.csproj`: builds the executable for this sample.

### P186_WarningWave7
Warning wave 7 is enabled via `AnalysisLevel`.
```csharp
Console.WriteLine("Warning wave 7 enabled via <AnalysisLevel>7.0</AnalysisLevel>.");
```
Files:
- `P186_WarningWave7/Program.cs`: prints the warning wave setting.
- `P186_WarningWave7/P182_WarningWave7.csproj`: builds the executable for this sample.

## Repository files
- `CSharpV110_Features.sln`: solution that includes all sample projects.
- `Directory.Build.props`: shared build settings (lang version, nullable, analysis level).
- `GlobalTargetFrameworkAttribute.cs`: shared assembly attribute for target framework metadata.
- `global.json`: pins the .NET SDK used by the solution.
- `README_V110.md`: original feature list reference.

## Build & Run
```bash
dotnet restore
dotnet build
dotnet run --project P172_RawStringLiterals
```
