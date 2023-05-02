using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Message2
    {
        [Key]
        public int ID { get; set; }
        public int? SenderID { get; set; }
        public int? ReceiverID { get; set; }
        public string Subject { get; set; }
        public string Details { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }

        //Bir tablodan aynı tablodaki farklı değerlere Id kısmını foreign key yapabilmek için tanımlıyoruz
        public AppUser SenderUser { get; set; }
        public AppUser ReceiverUser { get; set; }
    }
}
