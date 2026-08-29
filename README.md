[![](https://img.shields.io/nuget/v/soenneker.extensions.fieldinfo.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.fieldinfo/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.fieldinfo/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.fieldinfo/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.fieldinfo.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.fieldinfo/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.fieldinfo/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.fieldinfo/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.FieldInfo
A collection of helpful FieldInfo (Reflection) extension methods.

## Installation

```bash
dotnet add package Soenneker.Extensions.FieldInfo
```

## Quick start

```csharp
using Soenneker.Extensions.FieldInfo;

// Given an existing System.Reflection.FieldInfo named field:
var result = field.IsConstant();
```

## Common operations

- `IsConstant()` - Determines whether the specified field is a constant.
