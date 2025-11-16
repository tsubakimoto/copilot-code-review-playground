---
description: 'Guidelines for building C# applications (additional)'
applyTo: '**/*.cs'
---

# C# Development (additional)

## General Instructions

- When performing a code review, focus on readability and avoid nested ternary operators.
- Use `IHttpClientFactory` for creating `HttpClient` instances to avoid socket exhaustion and improve performance.

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
- Suffix class names with "Endpoint" for MinimalAPI endpoint classes (e.g., `UserEndpoint`).

## Class

- Don't use `public const` fields. Instead, use `public static readonly` for better versioning and compatibility.
- Use `record` types for immutable data structures and DTOs to leverage built-in value equality and concise syntax.
- Use `abstract` classes when you want to provide a common base with shared implementation for derived classes.
- Use `sealed` classes to prevent inheritance when a class is not intended to be a base class.
- Use primary constructors for records and classes to simplify initialization of properties.
- If the value cannot be set within the class, use `get;`.
- If the value can only be set within the class, use `get; private set;`.
- If the value can only be set in the constructor, use `get; init;`.

## Method

- Use type parameters with constraints to enforce specific behaviors (e.g., `where T : class`, `where T : struct`).
- Use `ArgumentNullException.ThrowIfNull` for null argument validation.

## String Handling

- Use `string.IsNullOrWhiteSpace` to check for null, empty, or whitespace strings.
- Use `string.Equals` with `StringComparison.OrdinalIgnoreCase` for case-insensitive string comparisons.
- Use `$` string interpolation for constructing strings with variables for better readability.
- Use `T.TryParse` methods for safe parsing of strings to numeric or enum types. Don't use `T.Parse` which throws exceptions on failure.
- Use `as` operator for safe type casting that returns `null` if the cast fails, instead of throwing an exception.

## LINQ and Collections

- Use `Any()` to check for the existence of elements in a collection instead of checking `Count > 0`.
- Do check for `null` before accessing the result of `FirstOrDefault()`, `LastOrDefault()`, `SingleOrDefault()`, or `ElementAtOrDefault()`.
- Return `IEnumerable<T>` from methods when the caller only needs to iterate over the collection, to allow for deferred execution and better performance.

## ASP.NET Core

- Use `IHttpContextAccessor` to access the current `HttpContext` in services where it's not directly available.
- Use `ILogger<T>` for logging within classes to leverage dependency injection and structured logging.

## Testing

- Use `xUnit` as the testing framework for unit tests.
- Use `NSubstitute` for mocking dependencies in unit tests.
