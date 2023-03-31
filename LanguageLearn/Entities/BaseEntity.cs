namespace LanguageLearn.Entities
{
    public class BaseEntity : IBaseEntity
    {
        public Guid Id { get; set; }=new Guid();
        public DateTime CreateDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
