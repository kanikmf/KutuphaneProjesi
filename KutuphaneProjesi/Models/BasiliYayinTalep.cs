using System.ComponentModel.DataAnnotations;

namespace KutuphaneProjesi.Models
{
    public class BasiliYayinTalep
    {
        [Key]
        public int BasılıYayınID { get; set; }  
        public string Yazar { get; set; } 
        public string YayınAdı { get; set; }
        public string Isbn { get; set; }
        public string YayinEvi { get; set; }
        public string YayınTarihi { get; set; }
        public bool İsActive { get; set; }
    }
}
