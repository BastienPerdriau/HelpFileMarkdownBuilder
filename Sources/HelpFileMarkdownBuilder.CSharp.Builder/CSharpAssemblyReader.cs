using HelpFileMarkdownBuilder.CSharp.Members;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace HelpFileMarkdownBuilder.CSharp.Builder
{
    /// <summary>
    /// Class to read assemblies to get members
    /// </summary>
    internal class CSharpAssemblyReader
    {
        /// <summary>
        /// Assemblies build configuration
        /// </summary>
        public string BuildConfiguration { get; set; } = "Release";

        /// <summary>
        /// List of project infos
        /// </summary>
        public List<ProjectInfo> ProjectInfos { get; internal set; }

        /// <summary>
        /// List of C-Sharp members
        /// </summary>
        public CSMemberCollection CSMembers { get; } = new CSMemberCollection();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="projectInfos">List of project infos</param>
        /// <param name="buildConfiguration">Build configuration</param>
        public CSharpAssemblyReader(List<ProjectInfo> projectInfos, string buildConfiguration)
        {
            ProjectInfos = projectInfos;
            BuildConfiguration = buildConfiguration;
        }

        /// <summary>
        /// Read assemblies to list members
        /// </summary>
        public void Read()
        {
            foreach (ProjectInfo projectInfo in ProjectInfos)
            {
                if (!projectInfo.BuildConfigurations.ContainsKey(BuildConfiguration))
                {
                    // TODO Logs warn
                    continue;
                }

                BuildConfiguration config = projectInfo.BuildConfigurations[BuildConfiguration];

                if (string.IsNullOrWhiteSpace(config.OutputPath))
                {
                    // TODO Logs warn
                    continue;
                }

                // Read assembly
                Assembly assembly = Assembly.LoadFile(Path.GetFullPath(config.OutputPath)); // Set full path in BuildConfiguration object

                // Create assembly object
                CSAssembly csAssembly = new CSAssembly(assembly);
                CSMembers.Add(csAssembly);

                // Run through all the types
                foreach (TypeInfo type in assembly.DefinedTypes)
                {
                    // Get the namespace object from the list of members
                    CSNamespace csNamespace = CSMembers.Namespaces.FirstOrDefault(n => n.Name == type.Namespace);

                    // If the namespace object does not exist, create it
                    if (csNamespace == null)
                    {
                        csNamespace = new CSNamespace(type.Namespace);
                        CSMembers.Add(csNamespace);
                    }

                    // Create type object
                    CSType csType = default;
                    if (type.IsClass)
                    {
                        // TODO Create class object
                        csType = new CSClass(csAssembly, csNamespace, type);
                    }

                    // Create type object
                    if (type.IsInterface)
                    {
                        // TODO Create interface object
                        csType = new CSInterface(csAssembly, csNamespace, type);
                    }

                    // Create type object
                    if (type.IsEnum)
                    {
                        // TODO Create enumeration object
                        csType = new CSEnumeration(csAssembly, csNamespace, type);
                    }

                    csAssembly.Types.Add(csType);
                    csNamespace.Types.Add(csType);
                    CSMembers.Add(csType);
                }

                if (string.IsNullOrWhiteSpace(config.DocumentationFilePath))
                {
                    // TODO Logs info
                    continue;
                }
            }
        }
    }
}
