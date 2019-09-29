using Project.Domain.Abstracts;

namespace Project.Domain.Entities
{
    public class CompanyEntity : BaseEntity
    {   public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }        
        public string Phone1 {get; set;}
        public string Phone2 {get; set;}
        public UserEntity User {get; set;}
        public AddressEntity Address {get; set;}
    }
}