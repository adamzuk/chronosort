using System;

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
            throw new NotImplementedException();
        }

        public override string GetUsage()
        {
            return string.Format(@"{0}|{1} Path\To\Config\File    sort files using config file passed as a argument", this.ShortOption, this.LongOption);
        }

        public override bool Validate()
        {
            return this.Value != null;
        }
    }
}
