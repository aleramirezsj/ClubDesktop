using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDesktop.Models
{
    public class Socio
    {
        public int Id { get; set; }
        public string ApellidoNombre { get; set; }
        public string Dirección { get; set; }
        public string Teléfono { get; set; }

        public override string ToString()
        {
            return ApellidoNombre;
        }
    }
}
