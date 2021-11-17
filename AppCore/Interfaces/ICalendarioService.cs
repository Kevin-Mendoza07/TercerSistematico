using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface ICalendarioService : IService<Calendario>
    {
        int GetLastIdCuota();
    }
}
