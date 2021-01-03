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

		public DbSet<Language> Dil { get; set; }
		public DbSet<Category> Categori { get; set; }
		public DbSet<City> City { get; set; }
		public DbSet<State> State { get; set; }
		public DbSet<User> User { get; set; }
		public DbSet<Car> Car { get; set; }
		public DbSet<Modeli> Modeli { get; set; }
		public DbSet<Origin> Origin { get; set; }
		public DbSet<ProjeOdevi.Models.Admin> Admin { get; set; }


	}
}
