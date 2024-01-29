using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NCRUD.Models
{
	public class Subscription
	{
		[Key]
		[DisplayName("Id")]
		public int Id { get; set; }

		[Required(ErrorMessage = "Informe o título do Premium")]
		[StringLength(80, ErrorMessage = "O título deve conter no máximo 80 caracteres!")]
		[MinLength(3, ErrorMessage = "O título deve conter no mínimo 3 caracteres!")]
		[DisplayName("Título")]
		public string Title { get; set; } = string.Empty;

		[DataType(DataType.DateTime)]
		[DisplayName("Inicio")]
		public DateTime StartDate { get; set; }

		[DataType(DataType.DateTime)]
		[DisplayName("Término")]
		public DateTime EndDate { get; set; }

		[DisplayName("Aluno")]
		[Required(ErrorMessage = "Aluno inválido")]
		public int StudentId { get; set; }	

		public Student? Student { get; set; }
	}
}
