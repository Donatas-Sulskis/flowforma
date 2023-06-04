using System.ComponentModel.DataAnnotations;

namespace ProductsAPI;

public class ProductTypes
{
    public int Id { get; set; }
     [StringLength(10)]
    public string Name { get; set; } = string.Empty;
}