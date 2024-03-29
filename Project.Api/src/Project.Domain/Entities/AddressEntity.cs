using Project.Domain.Abstracts;

namespace Project.Domain.Entities
{
    public class AddressEntity : BaseEntity
    {
        public string Countries {get; set;}
        public string State {get; set;}
        public string City {get; set;}
        public string District {get; set;}
        public string Street {get; set;}
        public string Number {get; set;}
        public string Complement {get; set;}
        public string ZipCode {get; set;}
        public string Longitude {get; set;}
        public string Altitude {get; set;}
        public string Obs {get; set;}
        
    }
}