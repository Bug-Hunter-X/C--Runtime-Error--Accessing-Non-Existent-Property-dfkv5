# C# Runtime Error: Accessing Non-Existent Property

This repository demonstrates a common runtime error in C# that occurs when attempting to access a property that does not exist. The code compiles without errors but throws a `System.NullReferenceException` or a compile-time error (if you set strict null checks) at runtime.

## The Bug

The `bug.cs` file contains C# code that attempts to access the `NonExistentProperty` within the `MyMethod` function. This property is not defined in the `ExampleClass`, leading to the runtime error.

## The Solution

The `bugSolution.cs` file provides a corrected version of the code. This solution shows the recommended practices to prevent this type of error.  It shows a more robust approach to handling potential null values, along with clear error messages.