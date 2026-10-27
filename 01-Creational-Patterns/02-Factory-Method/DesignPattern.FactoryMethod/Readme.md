# Factory Method Pattern Demo

This project demonstrates the **Factory Method** design pattern with a simple notification scenario.

## Scenario

A notification sender must support multiple channels:

- Email
- SMS
- Push notification

The client code only works with the abstract creator and the abstract product. The concrete creator decides which notification to create.

## Project structure

- `Program.cs` - runs the demo
- `Creators/` - factory method creators
- `Products/` - notification implementations

## Run

```bash
dotnet run --project 01.FactoryMethod.Notification.csproj
```

## Learning outcome

You will see how Factory Method removes direct dependencies on concrete classes and makes the code easier to extend.
