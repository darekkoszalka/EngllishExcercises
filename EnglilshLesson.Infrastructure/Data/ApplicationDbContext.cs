using System;
using EnglishLesson.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EnglilshLesson.Infrastructure.Data
{
	public class ApplicationDbContext : DbContext
	{
        private string _connectionString = "Server=localhost;Database=EnglishVocabularyDB;User=sa;Password=Docker@123;TrustServerCertificate=True;";

        public ApplicationDbContext()
		{
		}

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

		public DbSet<ThemeOfWord> ThemeOfWords { get; set; }
		public DbSet<Word> Words { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder builder)
		{
			builder.UseSqlServer(_connectionString);
		}
	}
}

