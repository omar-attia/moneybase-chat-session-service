using ChatSession.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatSession.Dal.Data.Entities;

[Table("Session")]
public class Session
{
    [Key]
    [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; } = new();
    public Guid ActorId { get; set; }
    [Required]
    [MaxLength(50)]
    public required string Status { get; set; } = SessionStatus.Pending.ToString();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime ExpiryDate { get; set; } = DateTime.UtcNow.AddHours(1);
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}

