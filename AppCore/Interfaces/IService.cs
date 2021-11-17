using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface IService<T>
    {
        void Add(T t);
        void Update(T t);
        List<T> GetAll();
    }
}
