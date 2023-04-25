using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class ReadEnderecoDto
{
    [Required]

    public int Id { get; set; }

    [Required(ErrorMessage = "O logradouro é obrigatório!")]
    public string Logradouro { get; set; }

    [Required(ErrorMessage = "O número é obrigatório!")]
    public int Numero { get; set; }
}
