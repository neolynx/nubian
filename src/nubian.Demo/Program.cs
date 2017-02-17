namespace nubian.Demo
{
    using System;
    using NEventStore;

    class Program
    {
//        [NubianAssemblyResolve]
        static void Main(string[] args)
        {
            var store = Wireup.Init()
                .UsingInMemoryPersistence()
                .UsingJsonSerialization()
                .Build();

            store.Dispose();
            Console.WriteLine("Shutting down");
        }
    }
}
