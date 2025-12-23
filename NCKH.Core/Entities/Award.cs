using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NCKH.Core.Entities;

public class Award
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int MaDeTai { get; set; }

    [Required]
    public decimal Diem { get; set; }

    [Required]
    [MaxLength(100)]
    public string TenGiai { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string MaGiai { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string CapGiai { get; set; } = string.Empty;

    [MaxLength(500)]
    public string?  GhiChu { get; set; }

    public DateTime NgayTrao { get; set; } = DateTime.Now;

    // Navigation
    [ForeignKey("MaDeTai")]
    public virtual Topic?  Topic { get; set; }
}
