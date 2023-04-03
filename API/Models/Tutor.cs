using System.ComponentModel.DataAnnotations;

namespace API.Models;

public class Tutor
{
    [Required(ErrorMessage = "O nome do tutor é obrigatório")]
    public string Nome { get; set; }


    [Required(ErrorMessage = "O email do tutor é obrigatório.")]
    public string Email { get; set; }


    [Required(ErrorMessage = "A senha do tutor é obrigatório")]
    [MinLength(8, ErrorMessage = "A senha do tutor deve conter, no mínino, 8 caracteres")]
    public string Senha { get; set; }
}
