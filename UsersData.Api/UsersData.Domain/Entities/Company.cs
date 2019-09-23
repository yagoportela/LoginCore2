namespace UsersData.Domain.Entities
{
    public class Company
    {   public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }        
        public string Phone1 {get; set;}
        public string Phone2 {get; set;}
        public int IdUser {get; set;}
    }
}