using System.ComponentModel.DataAnnotations;

namespace CodeFirst_Relation_Live.Models
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }
        public string PersonelName { get; set; }

        public virtual Department Departments { get; set; }

        public ICollection<Order> Orders { get; set; }

        public virtual City Cities { get; set; }
    }
}
