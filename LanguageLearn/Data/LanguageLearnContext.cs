using LanguageLearn.Entities;
using Microsoft.EntityFrameworkCore;

namespace LanguageLearn.Data
{
    public class LanguageLearnContext:DbContext
    {
        public LanguageLearnContext(DbContextOptions<LanguageLearnContext> options) : base(options)
        { 
        }

        public DbSet<Language> Languages { get; set; }
    }
}
