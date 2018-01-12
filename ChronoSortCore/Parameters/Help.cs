namespace ChronoSortCore.Parameters
{
    public class Help : Parameter
    {
        public Help()
        {
            this.ShortOption = "-h";
            this.LongOption = "-help";
        }

        public override bool Validate()
        {
            return this.Value == null;
        }
    }
}
