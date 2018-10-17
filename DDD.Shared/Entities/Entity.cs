using System;

namespace DDD.Shared.Entities
{
    public class Entity
    {
        public Entity()
        {
            ID = Guid.NewGuid();
            CreatedAt = DateTime.Now;

        }
        public Guid ID { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime ModifiedAt { get; private set; }
        public Guid UserModified { get; private set; }
    }
}
