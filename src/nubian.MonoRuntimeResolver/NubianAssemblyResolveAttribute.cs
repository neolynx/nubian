namespace System
{
    using nubian.MonoRuntimeResolver;

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public sealed class NubianAssemblyResolveAttribute : Attribute
    {
        public NubianAssemblyResolveAttribute()
        {
            AppDomain.CurrentDomain.ApplyNubianAssemblyResolve();
        }
    }
}
