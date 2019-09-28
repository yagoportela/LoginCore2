using System;
using Project.Domain.Abstracts;

namespace Project.Domain.Entities
{
    public class CustomersEntity : BaseEntity
    {
        public UserEntity UserEntity;
        public string CPF;
        public string RG;
        public DateTime BirthDate;
        public AddressEntity AddressEntity {get; set;}
                
    }
}