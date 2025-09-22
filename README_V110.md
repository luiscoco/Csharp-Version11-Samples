# C# 11.0 Features (VS 2022 / .NET 7)

Projects P168–P182 demonstrate the C# 11 features requested.

- Raw string literals
- Generic math support (`INumber<T>`)
- Generic attributes
- UTF-8 string literals (`"text"u8`)
- Newlines in string interpolation expressions
- List patterns
- File-local types (`file`)
- Required members
- Auto-default structs
- Pattern-match `Span<char>` on a constant string
- Extended `nameof` scope (usable in parameter attributes)
- Numeric `IntPtr`/`UIntPtr` operators
- `ref` fields and `scoped ref`
- Improved method group conversion to delegate
- Warning wave 7 (via `<AnalysisLevel>7.0</AnalysisLevel>`)

## Build & Run
```bash
dotnet restore
dotnet build
dotnet run --project P168_RawStringLiterals
```
