using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IRepository<T>
    {
        void Add(Calendario cln);
        List<T> GetAll();
        int GetLastIdCuota();
    }
}
