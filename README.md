# Avolutions BAF Domain

[![NuGet Version](https://img.shields.io/nuget/v/Avolutions.Baf.Domain)](https://www.nuget.org/packages/Avolutions.Baf.Domain)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Avolutions.Baf.Domain)](https://www.nuget.org/packages/Avolutions.Baf.Domain)

Reusable domain features for the Avolutions Business Application Framework (BAF).

## Installation

Install via [NuGet](https://www.nuget.org/packages/Avolutions.Baf.Domain):

```bash
dotnet add package Avolutions.Baf.Domain
```

## Quick Start

In your Program.cs, add BAF Domain to the service collection and middleware pipeline.

```csharp
using Avolutions.Baf.Core.Modules.Extensions;
using Avolutions.Baf.Domain.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Register EF Core DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register BAF Core and Blazor
builder.Services.AddBafCore<ApplicationDbContext>()
  .AddBafDomain();

var app = builder.Build();

// Initialize BAF Core and Domain
app.UseBafCore()
  .UseBafDomain();

app.Run();
```