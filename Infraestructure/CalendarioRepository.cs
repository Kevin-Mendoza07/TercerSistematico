using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infraestructure
{
    public class CalendarioRepository : ICalendarioRepository
    {
        private List<Calendario> calendario;
        private List<Calendario> calendariosBorrados;

        public CalendarioRepository()
        {
            calendariosBorrados = new List<Calendario>();
            calendario = new List<Calendario>();
        }

        public void Add(Calendario cln)
        {
            if (cln==null)
            {
                throw new ArgumentException("");

            }
            calendario.Add(cln); 
            
        }
        public int GetLastIdCuota()
        {
            Calendario dnt;
            Calendario dnt1;

            if (calendario.Count == 0 && calendariosBorrados.Count == 0)
            {
                return 0;
            }
            if (calendariosBorrados.Count == 0)
            {
                dnt = calendario.FindLast(D => D.Id > 0);
                return dnt.Id;
            }
            if (calendario.Count == 0)
            {
                dnt1 = calendariosBorrados.FindLast(D => D.Id > 0);
                return dnt1.Id;
            }
            dnt = calendario.FindLast(D => D.Id > 0);
            dnt1 = calendariosBorrados.FindLast(D => D.Id > 0);

            return dnt.Id > dnt1.Id ? dnt.Id : dnt1.Id;

        }
        public List<Calendario> GetAll()
        {
            return calendario;
        }
    }
}
