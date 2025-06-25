using Microsoft.EntityFrameworkCore;

namespace _3DPrintStore.Models
{
    public class Printable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<string>? Tags { get; set; }
        public string? Description { get; set; }
        public string? URL { get; set; }
        public bool? Verified { get; set; }
        public List<string>? Filaments { get; set; }
        public int Downloads { get; set; }
        public decimal Rating { get; set; }
        public int AuthorId { get; set; }
    }
}
