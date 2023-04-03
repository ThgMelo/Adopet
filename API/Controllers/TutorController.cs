using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Immutable;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class TutorController : ControllerBase
{
    private TutorContext _context;
    public TutorController(TutorContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult AdicionaTutor([FromBody] Tutor tutor)
    {
        _context.Tutores.Add(tutor);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperaTutorPorId), new {id = tutor.Id}, tutor);

    }


    [HttpGet]
    public IEnumerable<Tutor> RecuperaTutores()
    {
        return _context.Tutores;
    }


    [HttpGet("{id}")]
    public IActionResult RecuperaTutorPorId(int id)
    {
        var tutor = _context.Tutores.FirstOrDefault(tutor => tutor.Id == id);
        if (tutor == null) return NotFound();
        return Ok(tutor);
    }
}
