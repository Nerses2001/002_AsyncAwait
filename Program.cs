using _002_AsyncAwait;

Console.WriteLine("General ThreadId {0}", Environment.CurrentManagedThreadId);
MyClass myClass = new();

myClass.OperationAsync();
Console.ReadKey();