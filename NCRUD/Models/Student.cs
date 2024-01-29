﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NCRUD.Models;


public class Student
{
	[Key]
	[DisplayName("Id")]
	public int Id { get; set; }

	[Required(ErrorMessage = "Informe o nome")]
	[StringLength(80, ErrorMessage = "Onome deve conter até 80 caracteres!")]
	[MinLength(3, ErrorMessage = "O nome deve conter pelo menos 3 caracteres!")]
	[DisplayName("Nome Completo")]
	public string Name { get; set; } = string.Empty;

	[Required(ErrorMessage = "Informe o E-mail!")]
	[EmailAddress(ErrorMessage = "E-mail inválido!")]
	[DisplayName("E-mail")]
	public string Email{ get; set;} = String.Empty;

	public List<Subscription> Subscriptions { get; set; } = new();

}
