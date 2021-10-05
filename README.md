# TDD-Stack

Implementation of a simple Stack to learn TDD using C#.
The testing framework that will be used is MSTest.

# Stack Behavior

- Pop: An item can be popped off the stack.
- Last In First Out (LIFO) Stack.
- An empty stack doesn’t cause failure (throwing an exception).
- Null values cannot be pushed into the stack.

## Prerequisites

| **Programming Language** | **Testing Framework** | **Code editor**    | **Runtime** |
| ------------------------ | --------------------- | ------------------ | ----------- |
| C#                       | MSTest                | Visual Studio Code | .NET Core   |

## Creating The Project From Scratch

- Go to the directory where you want your project to be and run:

`dotnet new sln -o TDD-Stack`

- Go to that newly created directory

`cd TDD-Stack`

- Create a new class lib:

`dotnet new classlib -o Stack.Library`

**NOTE:** The dotnet new classlib command creates a new class library project in the Stack.Library folder. The new class library will contain the code to be tested.

- Rename the file Class1.cs to StackService.cs

`mv ./Stack.Library/Class1.cs ./Stack.Library/StackService.cs`

- Run the following command to add the class library project to the solution:

`dotnet sln add ./Stack.Library/Stack.Library.csproj`

- Create the Stack.Tests project by running the following command:

`dotnet new mstest -o Stack.Tests`

- Rename the file UnitTest1.cs to StackTests.cs

`mv ./Stack.Tests/UnitTest1.cs ./Stack.Tests/StackTests.cs`

- Add the test project to the solution file by running the following command:

`dotnet sln add ./Stack.Tests/Stack.Tests.csproj`

- Add the StackService class library as a dependency to the Stack.Tests project:

`dotnet add ./Stack.Tests/Stack.Tests.csproj reference ./Stack.Library/Stack.Library.csproj`

## Running the tests

- To run the tests, we will use a tool called dotnetWatcher. In order for it to work properly run:

`dotnet watch -p ./Stack.Tests/ test`

**NOTE:** The dotnet Watcher allows us to watch our code and rerun all our tests anytime a code file is changed and saved.
