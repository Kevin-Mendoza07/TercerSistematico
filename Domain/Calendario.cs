using Domain.Enums;
using System;

namespace Domain
{
    public class Calendario
    {
        public int Id { get; set; }
        public Tipo Tipo { get; set; }
        public Estado Estado { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaPaga { get; set; }
        public decimal Monto { get; set; }
        public int Terminos { get; set; }
        public decimal Tasa { get; set; }
        public decimal Principal { get; set; }
        public decimal Interest { get; set; }
        public decimal Impuestos { get; set; }
        public decimal MontoTotal { get; set; }

    }
}
