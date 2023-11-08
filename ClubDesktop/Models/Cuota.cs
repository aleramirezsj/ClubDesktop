using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDesktop.Models
{
    public class Cuota
    {
        public int Id { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }
        public DateTime Vencimiento { get; set; }
        public bool Cobrada { get; set; }
        public decimal Monto { get; set; }
        public int ActividadId { get; set; }
        public Actividad Actividad { get; set; }
        public int SocioId { get; set; }
        public Socio Socio { get; set; }
        public int? CobradorId { get; set; }
        public Cobrador Cobrador { get; set; }

        public override string ToString()
        {
            return $"{Mes} {Año} {Vencimiento.ToShortDateString()}";
        }
    }
}
