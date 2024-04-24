using System.ComponentModel.DataAnnotations;

namespace KutuphaneProjesi.Models
{
    public class AdminPanelUser
    {
        [Key]
        public int AdminID { get; set; }
        [StringLength(20)]
        public string UserName { get; set; }
        [StringLength(20)]
        public string Password { get; set; }

    }
}
