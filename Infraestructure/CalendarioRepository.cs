using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infraestructure
{
    public class CalendarioRepository
    {
        private List<Calendario> calendario;

        public CalendarioRepository()
        {
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
            return calendario.Last().Id;
        }
        public List<Calendario> GetAll()
        {
            return calendario;
        }
    }
}
