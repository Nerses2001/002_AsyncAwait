using System.Runtime.CompilerServices;

namespace _002_AsyncAwait
{
    internal class MyClass
    {
        public void Operation()
        {
            Console.WriteLine("Operation ThreadId {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Begin");
            Console.WriteLine("End");
        }

        public void OperationAsync()
        {
            AsyncStateMachine stateMachine;
            stateMachine.outer = this;
            stateMachine.builder = AsyncVoidMethodBuilder.Create();
            stateMachine.builder.Start(ref stateMachine);
        }
    }
}
