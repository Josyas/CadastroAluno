using System.ComponentModel.DataAnnotations;
namespace CadastroAluno.Models
{
    public class Aluno 
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Compo obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Compo obrigatório.")]
        [Display(Name ="Registo Academico")]
        public string RegistroAcademico { get; set; }
        [Required(ErrorMessage = "Compo obrigatório.")]
        public string Curso  { get; set; }
        [Required(ErrorMessage = "Compo obrigatório.")]
        public int CursoId { get; set; }
        [Display(Name = "Diciplina do curso")]
        public virtual Curso DiciplinasDoCurso { get; set; }
        [Required(ErrorMessage = "Compo obrigatório.")]
        public int Periodo { get; set; }
        [Required(ErrorMessage = "Compo obrigatório.")]
        public double Nota { get; set; }
        [Required(ErrorMessage = "Compo obrigatório.")]
        public string Status { get; set; }
       
    }
}
