using Project.Domain.Abstracts;

namespace Project.Domain.Entities
{
    public class CompanyEntity : BaseEntity
    {   public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }        
        public string Phone1 {get; set;}
        public string Phone2 {get; set;}
        public UserEntity UserEntity {get; set;}
        public AddressEntity AddressEntity {get; set;}
    }
}