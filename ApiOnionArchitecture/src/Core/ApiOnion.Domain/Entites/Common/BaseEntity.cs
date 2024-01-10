using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiOnion.Domain.Entites
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreadetAt { get; set; }

        public BaseEntity()
        {
            CreadetAt = DateTime.Now;
        }
    }
}
