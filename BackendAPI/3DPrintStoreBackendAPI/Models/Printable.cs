using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace _3DPrintStoreBackendAPI.Models;

public class Printable
{
    public int Id { get; set; }
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Name { get; set; }
    public List<string>? Tags { get; set; }
    [StringLength(500)]
    public string? Description { get; set; }
    public string? URL { get; set; }
    [Required]
    public bool? Verified { get; set; }
    public List<string>? Filaments { get; set; }
    public int Downloads { get; set; }
    public decimal Rating { get; set; }
    [Required]
    public int AuthorId { get; set; }
}
