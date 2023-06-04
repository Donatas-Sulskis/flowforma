using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsAPI.data;

namespace ProductsAPI.Controller;

[Route("api/[controller]")]
[ApiController]

public class ProductTypesController : ControllerBase
{
    private readonly DataContext _context;

    public ProductTypesController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductTypes>>> getProductTypes()
    {
        return await _context.ProductTypes.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<ProductTypes>> PostProductType(ProductTypes productType)
    {
        if (ProductTypeExists(productType.Name))
        {
            return BadRequest();
        }

        _context.ProductTypes.Add(productType);
        await _context.SaveChangesAsync();

        return CreatedAtAction("getProductTypes", new { id = productType.Id }, productType);
    }

    private bool ProductTypeExists(string name)
    {
        return _context.ProductTypes.Any(productType => productType.Name == name);
    }
}