using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Aspdotnetmcvcrud.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }

    [DisplayName("Display Order")]
    [Range(1,100,ErrorMessage ="Display Order must be 1 and 100 only!!!")]
    public int DisplayOrder { get; set; }
    public DateTime DateTime { get; set; } = DateTime.Now;

}