using System;
using Project.Domain.Abstracts;

namespace Project.Domain.Entities
{
    public class CustomersEntity : BaseEntity
    {
        public UserEntity User {get; set;}
        public string CPF {get; set;}
        public string RG {get; set;}
        public DateTime BirthDate {get; set;}
        public AddressEntity Address {get; set;}
                
    }
}