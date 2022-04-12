using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Message
    {
        [Key]
        public int MesajID { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        [StringLength(50)]
        public string Subject { get; set; }
        [StringLength(50)]
        public string MessageDetails { get; set; }
        public DateTime MessageDate { get; set; }
        public bool MessageStatus { get; set; }

    }
}
