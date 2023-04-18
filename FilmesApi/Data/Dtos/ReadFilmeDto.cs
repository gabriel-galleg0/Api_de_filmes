using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class ReadFilmeDto
    {

        public string Titulo { get; set; }

        public string Genero { get; set; }

        public int Duracao { get; set; }

        public string Diretor { get; set; }

        public string Sinopse { get; set; }

        public DateTime HoraConsultada { get; set; } = DateTime.Now;
    }
}
