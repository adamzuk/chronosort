using ChronoSortCore.Parameters;
using ChronoSortCore.Utils;
using System;

namespace ChronoSortCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var parameter = ValidateArgs(args);

            if (parameter == null)
            {
                return;
            }
            parameter.Execute();

            Console.ReadKey();
        }

        private static Parameter ValidateArgs(string[] args)
        {
            if (args.Length != 1)
            {
                Logger.GetLoggerInstance().Error("Invalid number of parameters.");
                return null;
            }
            else
            {
                var source = args[0].ToLower();
                var parameter = ParameterFactory.GetParameter(source);

                if (parameter == null)
                {
                    Logger.GetLoggerInstance().Error(string.Format("Unable to match '{0}' with any known parameter. Type -h/help for manual."));
                    return null;
                }
                return parameter.Validate() ? parameter : null;
            }
        }
    }
}