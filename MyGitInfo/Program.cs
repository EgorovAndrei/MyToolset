using System;

namespace MyGitInfo
{
    internal class Program
    {
        static void Main()
        {
            //чтобы увидеть ThisAssembly.Git.Commit в гите нужно глянуть на начальные цифры в главной ветке 

            //чтобы работало для прописи в description dll нужно добавить файл assemblyinfo, там заюзав эту инфу
            //и параметр <GenerateAssemblyInfo>false</GenerateAssemblyInfo> в csproj в секцию PropertyGroup

            Console.WriteLine("Hello World!");
            Console.WriteLine(ThisAssembly.Git.Commit);
            Console.WriteLine(ThisAssembly.Git.BaseVersion.Major);
            Console.WriteLine(ThisAssembly.Git.BaseVersion.Minor);
            Console.WriteLine(ThisAssembly.Git.BaseVersion.Patch);
        }
    }
}
