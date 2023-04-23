namespace ValidationFactory.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class DateData : Attribute
    {
        public DateData()
        {
        }
        public int minYear { get; set; }
    }
}