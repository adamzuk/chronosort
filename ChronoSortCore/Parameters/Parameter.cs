namespace ChronoSortCore.Parameters
{
    public abstract class Parameter
    {
        public string ShortOption { get; set; }

        public string LongOption { get; set; }

        public abstract bool Validate();
    }
}
