using Microsoft.AspNetCore.Mvc;
using primeraAppEnC_.Models;
using primeraAppEnC_.Data;



namespace primeraAppEnC_.Controllers
{
    public class PersonasController : Controller
    {   // Simulamos una base de datos en memoria con una lista de personas
        private readonly AppDbContext _context;

        public PersonasController(AppDbContext context)
        {
            _context = context;
        }
        // GET: Personas
        public IActionResult Index()
        {

            var personas = _context.Personas.ToList();
            return View(personas);
        }
        // GET: Personas/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        // POST: Personas/Create
        [HttpPost]
        public IActionResult Create(Persona persona)
        {
            if (!ModelState.IsValid)
                return View(persona);

            _context.Personas.Add(persona);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }



    }
}
