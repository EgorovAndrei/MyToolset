using System;

namespace MyGitInfo
{
    internal class Program
    {
        static void Main()
        {
            //чтобы работало для прописи в description dll нужно добавить assemblyinfo и параметр в csproj
            Console.WriteLine("Hello World!");
            Console.WriteLine(ThisAssembly.Git.Commit);
            Console.WriteLine(ThisAssembly.Git.BaseVersion.Major);
            Console.WriteLine(ThisAssembly.Git.BaseVersion.Minor);
            Console.WriteLine(ThisAssembly.Git.BaseVersion.Patch);
        }
    }
}
