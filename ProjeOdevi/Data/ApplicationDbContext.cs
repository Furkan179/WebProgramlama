using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjeOdevi.Models;

namespace ProjeOdevi.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<Car> Film { get; set; }
		public DbSet<Language> Dil { get; set; }
		public DbSet<Category> Kategori { get; set; }

	}
}
