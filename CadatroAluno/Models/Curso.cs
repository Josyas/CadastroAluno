using System.ComponentModel.DataAnnotations;
namespace CadastroAluno.Models
{
    public class Curso
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Compo obrigatório.")]
        [Display(Name = "Nome do curso")]
        public string NomeDoCurso { get; set; }
        [Required(ErrorMessage = "Compo obrigatório.")]
        [Display(Name = "Diciplina do curso")]
        public string DiciplinasDoCurso { get; set; }
    }
}
