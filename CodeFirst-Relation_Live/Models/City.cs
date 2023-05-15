namespace CodeFirst_Relation_Live.Models
{
    public class City
    {
        public int CityID { get; set; }
        public string CityName { get; set; }

        public ICollection<Personel> Personels { get; set;}
    }
}
