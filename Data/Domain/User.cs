using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Domain
{
    public class User : BaseEntity
    {
        public User()
        {
            CartProducts = new HashSet<Cart>();
        }
        public string Username { get; set; }
        public virtual ICollection<Cart> CartProducts { get; set; }
    }
}
