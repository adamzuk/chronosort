using ChronoSortCore.Parameters;
using ChronoSortCore.Utils;
using System;

namespace ChronoSortCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var validationResult = ValidateArgs(args);
            Console.ReadKey();
        }

        private static bool ValidateArgs(string[] args)
        {
            if (args.Length != 2)
            {
                Logger.GetLoggerInstance().Error("Invalid number of parameters.");
                return false;
            }
            else
            {
                var source = args[1].ToLower();
                var parameter = ParameterFactory.GetParameter(source);

                if (parameter == null)
                {
                    Logger.GetLoggerInstance().Error(string.Format("Unable to match '{0}' with any known parameter. Type -h/help for manual."));
                    return false;
                }
            }
            return true;
        }
    }
}