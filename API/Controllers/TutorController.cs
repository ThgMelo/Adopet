using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Immutable;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class TutorController : ControllerBase
{
    private static List<Tutor> tutores = new List<Tutor>();
    private static int id = 0;

    [HttpPost]
    public IActionResult AdicionaTutor([FromBody] Tutor tutor)
    {
        tutor.Id = id++;
        tutores.Add(tutor);
        return CreatedAtAction(nameof(RecuperaTutorPorId), new {id = tutor.Id}, tutor);

    }


    [HttpGet]
    public IEnumerable<Tutor> RecuperaTutores()
    {
        return tutores;
    }


    [HttpGet("{id}")]
    public IActionResult RecuperaTutorPorId(int id)
    {
        var tutor = tutores.FirstOrDefault(tutor => tutor.Id == id);
        if (tutor == null) return NotFound();
        return Ok(tutor);
    }
}
