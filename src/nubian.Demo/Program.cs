namespace nubian.Demo
{
    using NEventStore;

    class Program
    {
        static void Main(string[] args)
        {
            var store = Wireup.Init()
                .UsingInMemoryPersistence()
                .UsingJsonSerialization()
                .Build();

            store.Dispose();
        }
    }
}
