﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IRepository<T>
    {
        void Create();
        List<T> GetAll();
        int GetLastIdCuota();
    }
}
