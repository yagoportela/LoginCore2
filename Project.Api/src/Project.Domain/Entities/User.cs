using Project.Domain.Enum;

namespace Project.Domain.Entities
{
    public class User : BaseEntity
    {
        public string ImgPerfil { get; set; }
        public typeUsers Tipo {get; set;}
        
    }
}

