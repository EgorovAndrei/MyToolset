using Microsoft.Build.Evaluation;
using System.Reflection;

namespace MyReflection
{
    public class RefInfo
    {
        public static void GetInfoAboutReferences()
        {
            //var tmp = Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyDescriptionAttribute>().Description;
            var tmp2 = Assembly.GetEntryAssembly().GetReferencedAssemblies();
            foreach (var assemblyName in Assembly.GetExecutingAssembly().GetReferencedAssemblies())
            {
                Assembly assembly = Assembly.Load(assemblyName);
                foreach (var type in assembly.GetTypes())
                {
                    Console.WriteLine(type.Name);
                }
            }

            var projectCollection = new ProjectCollection();
            var projFile = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            var project = projectCollection.LoadProject(projFile);
            var projectReferences = project.GetItems("ProjectReference");

            foreach (var projectReference in projectReferences)
            {
                Console.WriteLine(projectReference.EvaluatedInclude);
            }
        }
    }
}
