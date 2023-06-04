using System.ComponentModel.DataAnnotations;

namespace ProductsAPI;

public class Products
{
    public int Id { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    [StringLength(200)]
    public string Details { get; set; } = string.Empty;
    public int ProductTypeId { get; set; }
}