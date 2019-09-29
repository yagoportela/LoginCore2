using Project.Domain.Abstracts;

namespace Project.Domain.Entities
{
    public class WorkshopEntity : BaseEntity
    {
        public UserEntity User {get; set;}
        public CompanyEntity Company {get; set;}
        public AddressEntity Address {get; set;}
        public string NameWorkshop {get; set;}        
        public string Phone1 {get; set;}
        public string Phone2 {get; set;}
    }
}