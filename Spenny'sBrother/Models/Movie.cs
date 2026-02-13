namespace Spenny_sBrother.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Category { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public string Director { get; set; } = string.Empty;
        public string Rating { get; set; } = string.Empty;
        public bool? Edited { get; set; }
        public string? LentTo { get; set; }
        public string? Notes { get; set; }
    }
}
