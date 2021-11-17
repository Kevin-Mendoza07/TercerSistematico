using AppCore.Interfaces;
using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public class CalendarioService : ICalendarioService
    {
        private ICalendarioRepository calendarioRepository;

        public CalendarioService(ICalendarioRepository calendarioRepository)
        {
            this.calendarioRepository = calendarioRepository;
        }
        public void Add(Calendario t)
        {
            calendarioRepository.Add(t);
        }

        public List<Calendario> GetAll()
        {
            return calendarioRepository.GetAll();
        }

        public int GetLastIdCuota()
        {
            return calendarioRepository.GetLastIdCuota();
        }

        public void Update(Calendario t)
        {
            throw new NotImplementedException();
        }
    }
}
