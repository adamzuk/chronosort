using System;

namespace ChronoSortCore.Parameters
{
    public class Source : Parameter
    {
        public Source()
        {
            this.ShortOption = "-s";
            this.LongOption = "-short";
        }

        public override bool Validate()
        {
            return this.Value != null;
        }
    }
}
