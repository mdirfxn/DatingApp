using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Shared.Domain
{
    public class Message : BaseDomainModel
    {
        public string? Content { get; set; }

        public int StaffId { get; set; }
        public virtual Staff? Staff { get; set; } 
        
    }
}
