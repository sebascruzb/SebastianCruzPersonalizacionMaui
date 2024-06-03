using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SebastianCruzPersonalizacionMaui.Models
{
    public class PromoSC
    {
        public int PromoId { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaPromo { get; set; }
        public int BurgerId { get; set; }
    }
}
