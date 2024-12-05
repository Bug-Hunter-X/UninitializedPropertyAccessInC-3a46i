# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it has been assigned a value. This can lead to unexpected behavior or exceptions, depending on the context.

## The Bug
The `bug.cs` file contains a class with a property `MyProperty` and a method `MyMethod`.  `MyMethod` attempts to use the value of `MyProperty` before it has been explicitly set.  If the property is of a value type (like `int`), the result is an unpredictable value.  If it's a reference type, a `NullReferenceException` might occur.

## The Solution
The `bugSolution.cs` file shows how to fix this.  Ensure that the property `MyProperty` is initialized before it is used in `MyMethod`.