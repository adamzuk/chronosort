using ChronoSortCore.Models;
using ChronoSortCore.Utils;
using System;
using System.Collections.Generic;
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

        public override int Execute()
        {
            Logger.GetLoggerInstance().Info(string.Format("Copying files to new destination using config: {0}\n\n", this.Value));

            List<ItemDecorator> deserializedConfig;
            try
            {
                deserializedConfig = SerializationHelper.Deserialize(this.Value);
            }
            catch (Exception e)
            {
                Logger.GetLoggerInstance().Error(string.Format("Unable to deserialize config file: {0}", e.Message));
                return -1;
            }

            var iterator = new CollectionInterator(deserializedConfig);
            ItemDecorator item = null;

            while ((item = iterator.Next()) != null)
            {
                Logger.GetLoggerInstance().Info(string.Format("Copying {0} ...", item.CurrentPath));

                File.Copy(item.CurrentPath, item.GetNewPath());
            }
            return 0;
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
