using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain
{
    public class Cart : BaseEntity
    {
        public DateTime DateCreated { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
