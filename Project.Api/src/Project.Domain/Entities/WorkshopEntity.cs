using Project.Domain.Abstracts;

namespace Project.Domain.Entities
{
    public class WorkshopEntity : BaseEntity
    {
        public UserEntity UserEntity {get; set;}
        public CompanyEntity CompanyEntity {get; set;}
        public AddressEntity AddressEntity {get; set;}
        public string NameWorkshop {get; set;}        
        public string Phone1 {get; set;}
        public string Phone2 {get; set;}
    }
}