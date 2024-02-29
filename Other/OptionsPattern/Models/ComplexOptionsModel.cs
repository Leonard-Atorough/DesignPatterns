namespace OptionsPattern.Models
{
    public class ComplexOptions
    {
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public List<ComplexSubOption> ComplexSubOptions { get; set; } = [];
    }

    public class ComplexSubOption
    {
        public string Name { get; set; } = string.Empty;
    }
}
