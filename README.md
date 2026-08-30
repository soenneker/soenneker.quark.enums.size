[![](https://img.shields.io/nuget/v/soenneker.quark.enums.size.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.size/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.size/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.size/actions/workflows/publish-package.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.size/build-and-test.yml?label=Build&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.size/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.enums.size.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.size/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.size/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.size/actions/workflows/codeql.yml)

# Soenneker.Quark.Enums.Size

Semantic component-size tokens shared by Quark APIs.

## Install

```bash
dotnet add package Soenneker.Quark.Enums.Size
```

## Usage

```csharp
SizeType size = SizeType.Large;
string suffix = size.Value; // "lg"
```

The values are size identifiers rather than CSS lengths. Components decide how each identifier maps to padding, typography, dimensions, or generated class names.

`Default.Value` is an empty string, which lets class composition omit a size suffix:

```csharp
string modifier = SizeType.Default.Value; // ""
```

## Values

| Member | Value |
| --- | --- |
| `Default` | empty string |
| `ExtraSmall` | `xs` |
| `Small` | `sm` |
| `Medium` | `md` |
| `Large` | `lg` |
| `ExtraLarge` | `xl` |
| `ExtraExtraLarge` | `2xl` |
