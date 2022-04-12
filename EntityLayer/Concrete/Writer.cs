using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }

        [StringLength(50)]
        public string WriterName { get; set; }

        [StringLength(250)]
        public string WriterAbout { get; set; }

        [StringLength(250)]
        public string WriterImage { get; set; }

        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }

        public bool WriterStatus { get; set; }
        public List<Blog> Blogs { get; set; }
        public virtual ICollection<Message2> WriterSender { get; set; }
        public virtual ICollection<Message2> WriterReceiver { get; set; }


    }
}
