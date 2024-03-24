﻿namespace CrudUsuarios.Models;

public partial class User
{
	public int Id { get; set; }

	public string Name { get; set; } = null!;

	public string Email { get; set; } = null!;

	public string Password { get; set; } = null!;

	public DateTime CreatedAt { get; set; }

	public DateTime UpdatedAt { get; set; }
}
