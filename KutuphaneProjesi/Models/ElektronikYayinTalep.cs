using System.ComponentModel.DataAnnotations;

namespace KutuphaneProjesi.Models
{
    public class ElektronikYayinTalep
    {    
        [Key]
        public int YazarID { get; set; }
        public string YazarAdı { get; set; }
        public string YayınAdı { get; set; }
        public string YayınEvi { get; set; }
        public string Eisbn { get; set; }
        public string Nitelik { get; set; }
        public bool IsActive { get;set; }
    }
}

