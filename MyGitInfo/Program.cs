using System;

namespace MyGitInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(ThisAssembly.Git.Commit);
        }
    }
}
