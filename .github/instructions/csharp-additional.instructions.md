---
description: 'Guidelines for building C# applications (additional)'
applyTo: '**/*.cs'
---

# C# Development (additional)

## Naming Conventions

- Suffix interface names with "Repository" when they represent data access layers (e.g., `IUserRepository`).
- Suffix interface names with "Service" when they represent service layers (e.g., `IUserService`).
- Prefix method names with "Is", "Has", or "Can" for boolean-returning methods (e.g., `IsActive`, `HasPermission`, `CanExecute`).
- Prefix method names with "Get", "Set", "Add", "Remove", "Update" to indicate their primary action (e.g., `GetUser`, `SetUserName`, `AddItem`).
- Suffix async method names with "Async" (e.g., `GetUserAsync`).
- Suffix class names with "Repository" for data access classes (e.g., `UserRepository`).
- Suffix class names with "Service" for service layer classes (e.g., `UserService`).
- Suffix class names with "Base" for base classes (e.g., `UserBase`).
- Suffix class names with "Controller" for ASP.NET Core controllers (e.g., `UserController`).
- Suffix class names with "Endpoint" for minimal API endpoint classes (e.g., `UserEndpoint`).

## Class Conventions

- Don't use `public const` fields. Instead, use `public static readonly` for better versioning and compatibility.
- Use `record` types for immutable data structures and DTOs to leverage built-in value equality and concise syntax.
- Use `abstract` classes when you want to provide a common base with shared implementation for derived classes.
- Use `sealed` classes to prevent inheritance when a class is not intended to be a base class.
- If the value cannot be set within the class, use `get;`.
- If the value can only be set within the class, use `get; private set;`.
- If the value can only be set in the constructor, use `get; init;`.
