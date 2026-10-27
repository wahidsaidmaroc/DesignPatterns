# Prototype Pattern Demo

This project demonstrates the **Prototype** design pattern with a document cloning example.

## Scenario

A document template can be reused by cloning an existing object and changing a few fields:

- Title
- Author
- Sections

This avoids rebuilding the whole document structure every time.

## Project structure

- `Program.cs` - runs the demo
- `Documents/` - prototype base class and concrete document

## Run

```bash
dotnet run --project 01.Prototype.Document.csproj
```

## Learning outcome

You will see how cloning an existing instance can simplify object creation and preserve complex state.
