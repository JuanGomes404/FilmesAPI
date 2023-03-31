using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme
{
    [Required(ErrorMessage = "O titulo do filme é obrigatório")]
    public string titulo { get; set; }

    [Required (ErrorMessage = "O tempo de duração do filme é obrigatório")]
    [MinLength(5, ErrorMessage = "O tempo é menor do que o permitido - 5 minutos")]
    [MaxLength(400, ErrorMessage = "O tempo exece o limite permitido: 500 minutos")]
    public int tempoDeDuracao { get; set; }

    [Required (ErrorMessage = "O genero do filme é obrigatório")]
    [Range(5, 600, ErrorMessage ="A duração do filme deve ser entre 5 e 600 minutos")]
    public string genero { get; set; }

    [Required (ErrorMessage = "O país de origem é obrigatório")]
    public string pais { get; set; }

    [Required (ErrorMessage = "O nome do diretor é obrigatório")]
    public string diretor { get; set; }
}
