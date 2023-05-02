using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string NameSurname { get; set; }
        public string ImageUrl { get; set; }
        public List<Blog> Blogs { get; set; }

        //Bir tablodan aynı tablodaki farklı değerlere Id kısmını foreign key yapabilmek için tanımlıyoruz
        public virtual ICollection<Message2> Senders { get; set; }
        public virtual ICollection<Message2> Receivers { get; set; }
    }
}
