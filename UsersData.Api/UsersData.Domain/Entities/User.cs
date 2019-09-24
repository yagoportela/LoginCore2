using UsersData.Domain.Enum;

namespace UsersData.Domain.Entities
{
    public class User : BaseEntity
    {
        public string ImgPerfil { get; set; }
        public typeUsers Tipo {get; set;}
        
    }
}

