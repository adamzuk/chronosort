using ChronoSortCore.Utils;
using System.IO;

namespace ChronoSortCore.Parameters
{
    public class Source : Parameter
    {
        public Source()
        {
            this.ShortOption = "-s";
            this.LongOption = "-source";
        }

        public override void Execute()
        {
            if (!Validation.ValidateIfFileExists(this.Value))
            {
                return;
            }
            Logger.GetLoggerInstance().Info(string.Format("Copying files to new destination using config: {0}\n\n", this.Value));

            var collection = SerializationHelper.Deserialize(this.Value);

            foreach (var item in collection)
            {
                Logger.GetLoggerInstance().Info(string.Format("Copying {0} ...", item.CurrentPath));

                File.Copy(item.CurrentPath, item.GetNewPath());
            }
        }

        public override string GetUsage()
        {
            return string.Format(@"{0}|{1} Path\To\Config\File            sort files using config file passed as an argument", this.ShortOption, this.LongOption);
        }

        public override bool Validate()
        {
            return this.Value != null;
        }
    }
}
