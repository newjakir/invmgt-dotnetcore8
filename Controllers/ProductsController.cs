using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using InvMgt.Models;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase {
    private readonly AppDbContext _context;
    public ProductsController(AppDbContext context) => _context = context;

    [HttpGet]
    public async Task<IActionResult> Get() => Ok(await _context.Products.ToListAsync());
}
