using System.ComponentModel.DataAnnotations;

namespace CardUsersAPI.Models;

public class Usuario
{

    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    [StringLength(100)]
    public string Nome { get; set; }
    [Required]
    [StringLength(100)]
    public string Email { get; set; }
    [Required]
    [StringLength(100)]
    public string Cargo { get; set; }
      
}
