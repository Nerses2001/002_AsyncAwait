
using System.Runtime.CompilerServices;

namespace _002_AsyncAwait
{
    internal struct AsyncStateMachine: IAsyncStateMachine
    {
        public MyClass outer;
        public AsyncVoidMethodBuilder builder;

         public readonly void MoveNext()
        {
            Task task = new(outer.Operation);
            task.Start();

        }

        public void SetStateMachine(IAsyncStateMachine stateMachine)
        {
            throw new NotImplementedException();
        }
    }
}
