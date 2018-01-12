using System;
using System.Reflection;
using System.Linq;

namespace ChronoSortCore.Parameters
{
    public class ParameterFactory
    {
        public static Parameter GetParameter(string command)
        {
            // Loading ChronoSortCore assembly is needed for test purposes
            var assembly = Assembly.Load(new AssemblyName("ChronoSortCore"));

            var types = assembly.GetTypes().Where(t => t.GetTypeInfo().BaseType == typeof(Parameter)).ToList();

            var correctType = types.FirstOrDefault(t =>
            {
                var instance = Activator.CreateInstance(t) as Parameter;

                var splittedCommand = command.Split(new[] { ' ' }, 2).First();

                return splittedCommand == instance.ShortOption || splittedCommand == instance.LongOption;
            });

            return correctType == null ? null : Activator.CreateInstance(correctType) as Parameter;
        }
    }
}
