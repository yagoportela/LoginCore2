using Project.Domain.Enum;
using Project.Domain.Abstracts;

namespace Project.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public string ImgPerfil { get; set; }
        public typeUsers Tipo {get; set;}       
        
    }
}

