# 002_AsyncAwait
## Example of Asynchronous Programming Without Using `async` and `await` in C#

This repository presents an example of asynchronous programming without using the `async` and `await` keywords in C#. The program demonstrates the usage of the `AsyncStateMachine` structure and `AsyncVoidMethodBuilder`.

## IAsyncStateMachine

[`IAsyncStateMachine`](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.iasyncstatemachine) represents an interface implemented for creating an asynchronous state machine. In this example, `AsyncStateMachine` implements `IAsyncStateMachine` to manage asynchronous operations without using `async` and `await`.

## AsyncVoidMethodBuilder

[`AsyncVoidMethodBuilder`](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.asyncvoidmethodbuilder) is a structure designed to support asynchronous methods that return `void`. It allows launching asynchronous operations and managing their results. In this example, `AsyncVoidMethodBuilder` is used to create an asynchronous state machine.

## Code

The example code is contained in two files: `AsyncStateMachine.cs` and `MyClass.cs`.

### AsyncStateMachine.cs

```csharp
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace _002_AsyncAwait
{
    internal struct AsyncStateMachine : IAsyncStateMachine
    {
        public MyClass outer;
        public AsyncVoidMethodBuilder builder;

        public void MoveNext()
        {
            Task task = new Task(outer.Operation);
            task.Start();
        }

        public void SetStateMachine(IAsyncStateMachine stateMachine)
        {
            throw new System.NotImplementedException();
        }
    }
}
```