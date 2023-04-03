using API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class TutorController : ControllerBase
{
    private static List<Tutor> tutores = new List<Tutor>();
    private static int id = 0;

    [HttpPost]
    public void AdicionaTutor(Tutor tutor)
    {
        tutor.Id = id++;
        tutores.Add(tutor);
        Console.WriteLine(tutor.Nome);
        Console.WriteLine(tutor.Email); ;
    }


    [HttpGet]
    public IEnumerable<Tutor> RecuperaTutores()
    {
        return tutores;
    }


    [HttpGet("{id}")]
    public Tutor? RecuperaTutorPorId(int id)
    {
        return tutores.FirstOrDefault(tutor => tutor.Id == id);
    }
}
