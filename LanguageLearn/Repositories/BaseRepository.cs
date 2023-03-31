using LanguageLearn.Data;
using LanguageLearn.Entities;
using Microsoft.EntityFrameworkCore;

namespace LanguageLearn.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly LanguageLearnContext _context;

        public BaseRepository(LanguageLearnContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _context.Set<TEntity>().
                 AsNoTracking()
                 .FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task CreateAsync(TEntity entity)
        {
            await _context.Set<TEntity>()
                 .AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(TEntity entity)
        {
            _context.Set<TEntity>()
                .Update(entity);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
