using System.ComponentModel.DataAnnotations;

namespace CodeFirst_Relation_Live.Models
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        public string DepartmanName { get; set; }

        public ICollection<Personel> Personels { get; set; }

    }
}
