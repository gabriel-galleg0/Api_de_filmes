﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.NovaPasta2;

public class UpdateFilmeDto
{

    [Required(ErrorMessage = "O titulo do filme é obrigatório!")]
    [MaxLength(50, ErrorMessage = "O tamanho do titulo não pode exceder 50 caracteres")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O genero do filme é obrigatório!")]
    [StringLength(50, ErrorMessage = "O tamanho do genero não pode exceder 50 caracteres")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A duração do filme é obrigatório!")]
    [Range(70, 600, ErrorMessage = "A duração deve ser dentro de 70 a 600 minutos")]
    public int Duracao { get; set; }

    [Required(ErrorMessage = "O diretor do filme é obrigatório!")]
    [StringLength(50, ErrorMessage = "O nome do(a) diretor(a) não pode exceder 50 caracteres")]
    public string Diretor { get; set; }


    [Required(ErrorMessage = "A sinopse do filme é obrigatória")]
    [StringLength(500, ErrorMessage = "A sinopse não pode conter mais de 500 caracteres")]

    public string Sinopse { get; set; }
}
