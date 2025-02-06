# Uninitialized Property Access in C#

This repository demonstrates a common C# bug: accessing a property before it's been assigned a value.  Uninitialized properties might contain default values, potentially leading to unexpected results in your program.

## Bug Description
The `Bug.cs` file shows a class with a property `MyProperty` that's not initialized before being read in the `MyMethod()` function. This can lead to the method returning a default value, instead of the expected value. 

## Solution
The `BugSolution.cs` file demonstrates the correct way to initialize properties or add checks before using their values.   