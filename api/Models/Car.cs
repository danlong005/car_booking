using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models;

[Table("cars")]
public class Car
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    [Column("id")]
    public Guid Id { get; set; }
    [Column("make")]
    public string Make { get; set; }
    [Column("model")]
    public string Model { get; set; }
    [Column("year")]
    public int Year { get; set; }
}