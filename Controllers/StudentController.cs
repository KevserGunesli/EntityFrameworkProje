using efproje.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EfProje.Controllers;

public class StudentController : Controller
{
    private readonly DataContext _context;
    public StudentController(DataContext context)
    {
        _context = context;
    }
    public IActionResult Create()
    {
        return View();
    }
    
    

    
}