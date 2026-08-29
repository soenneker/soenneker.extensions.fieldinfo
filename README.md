[![](https://img.shields.io/nuget/v/soenneker.extensions.fieldinfo.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.fieldinfo/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.fieldinfo/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.fieldinfo/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.fieldinfo.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.fieldinfo/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.fieldinfo/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.fieldinfo/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.FieldInfo
Answers whether reflection metadata represents a compile-time constant.

## Installation

```bash
dotnet add package Soenneker.Extensions.FieldInfo
```

## Usage

```csharp
using Soenneker.Extensions.FieldInfo;

FieldInfo field = typeof(HttpStatusCode).GetField(nameof(HttpStatusCode.OK))!;
bool constant = field.IsConstant(); // true
```

`IsConstant()` returns the field's `IsLiteral` flag. It is true for `const` fields and enum members, but false for `static readonly` fields. The `FieldInfo` must be non-null.
