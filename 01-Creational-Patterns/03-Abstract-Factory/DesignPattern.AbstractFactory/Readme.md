# Abstract Factory Pattern Demo

This project demonstrates the **Abstract Factory** design pattern with a small UI theme example.

## Scenario

The application needs to create related UI elements that must match the same theme:

- Button
- Checkbox

The theme factory creates the full family of objects, so the client can switch from light to dark theme without changing the rest of the code.

## Project structure

- `Program.cs` - runs the demo
- `Factories/` - abstract factory and concrete factories
- `Products/` - themed UI controls

## Run

```bash
dotnet run --project 01.AbstractFactory.UI.csproj
```

## Learning outcome

You will see how Abstract Factory keeps related products consistent and hides concrete implementation details.
