using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SebastianCruzPersonalizacionMaui.Models
{
    public class BurgerSC
    {
        public int BurgerId { get; set; }
        public string? Name { get; set; }
        public bool WithCheese { get; set; }
        public decimal Precio { get; set; }
    }
}
