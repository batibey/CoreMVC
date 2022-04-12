using System.ComponentModel.DataAnnotations;

namespace CoreMVC.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage = "Rol Adı Girin")]
        public string name { get; set; }
    }
}
