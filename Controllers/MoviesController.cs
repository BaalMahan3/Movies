using Microsoft.AspNetCore.Mvc;
using Movies4UFree.Data;
using Movies4UFree.Models;
using System.Linq;
namespace Movies4UFree.Controllers;

public class MoviesController : Controller
{
    private readonly ApplicationDbContext _context;

    public MoviesController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        // Fetch dynamic content from database
        var movies = _context.Movies.ToList(); // Assuming you have a Movies table
        return View(movies);
    }

    public IActionResult Details(int id)
    {
        var movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);
        if (movie == null)
        {
            return NotFound();
        }
        return View(movie);
    }
}