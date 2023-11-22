using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoWorldLeauge.Domain.Entities
{
    public class Draw : BaseEntity
    {
        public string drawerFirstName{ get; set; }
        public string drawerLastName{ get; set; }
        public DateTime drawDate { get; set; }
        public Group Group { get; set; }
    }
}
