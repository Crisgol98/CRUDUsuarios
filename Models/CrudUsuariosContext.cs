using Microsoft.EntityFrameworkCore;

namespace CrudUsuarios.Models;

public partial class CrudUsuariosContext : DbContext
{
	public CrudUsuariosContext(DbContextOptions<CrudUsuariosContext> options)
		: base(options)
	{
	}

	public virtual DbSet<User> Users { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<User>(entity =>
		{
			entity.Property(e => e.Id).HasColumnName("id");
			entity.Property(e => e.CreatedAt)
				.HasColumnType("datetime")
				.HasColumnName("created_at");
			entity.Property(e => e.Email)
				.HasMaxLength(50)
				.IsFixedLength()
				.HasColumnName("email");
			entity.Property(e => e.Name)
				.HasMaxLength(50)
				.IsFixedLength()
				.HasColumnName("name");
			entity.Property(e => e.Password)
				.HasMaxLength(100)
				.IsFixedLength()
				.HasColumnName("password");
			entity.Property(e => e.UpdatedAt)
				.HasColumnType("datetime")
				.HasColumnName("updated_at");
		});

		OnModelCreatingPartial(modelBuilder);
	}

	partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
