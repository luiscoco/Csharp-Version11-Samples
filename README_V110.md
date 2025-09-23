# C# 11 Features – Sample Projects

This repository contains hands-on examples of the new features introduced in **C# version 11** (shipped with .NET 7).  
Each project illustrates one feature with runnable code.

---

## 🚀 New Features in C# 11

### 1. Raw String Literals (`P170_RawStringLiterals`)
- **What’s new**: Triple-quoted strings can span multiple lines and include quotes/whitespace without escaping.
- **Example**:
  ```csharp
  string raw = """This is a "raw" string literal""";
  Console.WriteLine(raw);
  ```
- **Before**: Had to escape quotes (`"This is a \"raw\" string literal"`).

---

### 2. Generic Attributes (`P171_GenericAttributes`)
- **What’s new**: Attribute classes can now have generic type parameters.
- **Example**:
  ```csharp
  class MyAttribute<T> : Attribute { }
  [MyAttribute<int>] class Demo { }
  ```

---

### 3. UTF-8 String Literals (`P172_Utf8StringLiterals`)
- **What’s new**: String literals with `u8` suffix create UTF-8 encoded byte spans.
- **Example**:
  ```csharp
  ReadOnlySpan<byte> utf8 = "Hello"u8;
  ```

---

### 4. Newlines in String Interpolations (`P173_InterpolationNewLines`)
- **What’s new**: Interpolated string expressions `{ ... }` can now span multiple lines.
- **Example**:
  ```csharp
  var result = $"Sum is {
      1 + 2 + 3
  }";
  ```

---

### 5. List Patterns (`P174_ListPatterns`)
- **What’s new**: Match arrays or lists using `[ ... ]` pattern syntax.
- **Example**:
  ```csharp
  int[] numbers = { 1, 2, 3 };
  if (numbers is [1, 2, 3]) Console.WriteLine("Matched!");
  ```

---

### 6. File-local Types (`P175_FileLocalTypes`)
- **What’s new**: Types scoped to a single file.
- **Example**:
  ```csharp
  file class Helper { }
  ```

---

### 7. Required Members (`P176_RequiredMembers`)
- **What’s new**: Members marked `required` must be initialized.
- **Example**:
  ```csharp
  class Person
  {
      public required string Name { get; init; }
  }
  ```

---

### 8. Auto-default Structs (`P177_AutoDefaultStructs`)
- **What’s new**: Struct fields are default-initialized even if constructor doesn’t.
- **Example**:
  ```csharp
  struct Point { public int X, Y; }
  var p = new Point(); // X=0, Y=0
  ```

---

### 9. Pattern Matching on Spans (`P178_SpanPatternMatching`)
- **What’s new**: Pattern match `Span<char>`/`ReadOnlySpan<char>` against constant strings.
- **Example**:
  ```csharp
  ReadOnlySpan<char> span = "hello";
  if (span is "hello") Console.WriteLine("Match!");
  ```

---

### 10. Extended nameof Scope (`P179_ExtendedNameof`)
- **What’s new**: `nameof` can be used with parameters, locals, etc.
- **Example**:
  ```csharp
  void Print(string name) => Console.WriteLine(nameof(name));
  ```

---

### 11. Native-Sized Integers (`P180_NativeIntegers`)
- **What’s new**: Better support for `nint` and `nuint` types.
- **Example**:
  ```csharp
  nint x = 5;
  nuint y = 10;
  ```

---

### 12. Ref Fields and Scoped Ref (`P181_RefFieldsScoped`)
- **What’s new**: You can declare `ref` fields and scoped references.
- **Example**:
  ```csharp
  ref struct Buffer
  {
      private ref int _value;
  }
  ```

---

### 13. Method Group Conversion Improvements (`P182_MethodGroupConversion`)
- **What’s new**: Method groups convert to delegates more efficiently (caching).
- **Example**:
  ```csharp
  Action a = Console.WriteLine;
  a("Hello");
  ```

---

## 📂 Repository Structure

- `P170_RawStringLiterals` → raw string literals  
- `P171_GenericAttributes` → generic attributes  
- `P172_Utf8StringLiterals` → UTF-8 literals  
- `P173_InterpolationNewLines` → newlines in interpolated strings  
- `P174_ListPatterns` → list patterns  
- `P175_FileLocalTypes` → file-local types  
- `P176_RequiredMembers` → required members  
- `P177_AutoDefaultStructs` → auto-default structs  
- `P178_SpanPatternMatching` → pattern match spans  
- `P179_ExtendedNameof` → extended nameof scope  
- `P180_NativeIntegers` → nint/nuint  
- `P181_RefFieldsScoped` → ref fields & scoped ref  
- `P182_MethodGroupConversion` → method group conversion  

---

## 🔧 Requirements

- .NET 7 SDK  
- C# 11 compiler enabled  

To run any sample:
```bash
cd P170_RawStringLiterals
dotnet run
```

---

## 📖 References

- [What’s new in C# 11 – Microsoft Docs](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11)
