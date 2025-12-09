using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teknoroma.Entities.Enums;

namespace Teknoroma.Entities
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; } 
        public DataStatus Status { get; set; } = DataStatus.Active;

    }
}