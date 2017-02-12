namespace nubian.MonoRuntimeResolver
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Reflection;

    public static class AppDomainExtensions
    {
        public static void ApplyNubianAssemblyResolve(this AppDomain appDomain)
        {
            if (Environment.OSVersion.Platform != PlatformID.Unix)
            {
                Trace.TraceWarning("Currently nubian only supports Mono");
                return;
            }

            appDomain.AssemblyResolve += OnAssemblyResolve;
        }

        private static Assembly OnAssemblyResolve(object sender, ResolveEventArgs args)
        {
            var assemblyName = new AssemblyName(args.Name);
            var path = Path.Combine(
                "/opt",
                "nubian",
                $"{assemblyName.Name}.{assemblyName.Version}",
                $"{assemblyName.Name}.dll");

            return Assembly.LoadFrom(path);
        }
    }
}