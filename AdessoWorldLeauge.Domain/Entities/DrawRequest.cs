using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoWorldLeauge.Domain.Entities
{
    public class DrawRequest
    {
        public string DrawerFirstName { get; set; }
        public string DrawerLastName { get; set; }
        public int GroupCount { get; set; }

        // İsteğe bağlı olarak ekleyebileceğiniz diğer alanlar:
        // public DateTime DrawDate { get; set; }
        // public string AdditionalNotes { get; set; }
    }

}
