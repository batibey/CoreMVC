using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        [StringLength(200)]
        public string CategoryDescription { get; set; }

        public DateTime CategoryDate { get; set; }

        public bool CategoryStatus { get; set; }

        public List<Blog> Blogs { get; set; }

    }
}
