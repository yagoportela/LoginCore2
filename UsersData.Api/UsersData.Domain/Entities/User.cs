using UsersData.Domain.Enum;

namespace UsersData.Domain.Entities
{
    public class User : BaseEntity
    {
        public string ImgPerfil { get; set; }
        public string Name { get; set; }
        public string nickname { get; set; }
        public string Email { get; set; }
        public string Cell_phone {get; set;}
        public string tipo {get; set;}
        public typeUsers Tipo {get; set;}
        
    }
}

