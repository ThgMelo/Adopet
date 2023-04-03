using API.Models;
using Microsoft.AspNetCore.Mvc;
namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class TutorController : ControllerBase
{
    private static List<Tutor> tutores = new List<Tutor>();

    [HttpPost]
    public void AdicionaTutor(Tutor tutor)
    {
        tutores.Add(tutor);
        Console.WriteLine(tutor.Nome);
        Console.WriteLine(tutor.Email); ;
    }
}
