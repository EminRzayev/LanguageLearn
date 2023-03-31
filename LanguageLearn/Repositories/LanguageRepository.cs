using LanguageLearn.Data;
using LanguageLearn.Entities;

namespace LanguageLearn.Repositories
{
    public class LanguageRepository : BaseRepository<Language>, ILanguageRepository
    {
        public LanguageRepository(LanguageLearnContext context) : base(context)
        {
        }
    }
}
