namespace LanguageLearn.Entities
{
    public interface IBaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
