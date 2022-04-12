using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Message2
    {
        [Key]
        public int MesajID { get; set; }
        public int? SenderID { get; set; }
        public int? ReceiverID { get; set; }
        
        public string Subject { get; set; }
        [StringLength(50)]
        public string MessageDetails { get; set; }
        public DateTime MessageDate { get; set; }
        public bool MessageStatus { get; set; }
        public Writer SenderUser { get; set; }
        public Writer ReceiverUser { get; set; }
    }
}
