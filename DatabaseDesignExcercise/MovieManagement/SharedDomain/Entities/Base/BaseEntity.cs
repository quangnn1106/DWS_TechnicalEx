using System.ComponentModel.DataAnnotations;


namespace SharedDomain.Entities.Base
{
    public abstract class BaseEntity : IBaseEntity<Guid>, ITraceableItem
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        private DateTime? _deletedDate;
        public DateTime? DeletedDate
        {
            get
            {
                if (IsDeleted && !_deletedDate.HasValue)
                {
                    _deletedDate = UpdatedDate;
                }
                return _deletedDate;
            }
            set
            {
                _deletedDate = value;
            }
        }

    }
}
