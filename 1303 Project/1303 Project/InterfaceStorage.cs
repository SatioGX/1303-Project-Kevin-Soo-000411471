using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1303_Project
{
    public interface InterfaceStorage<T>
    {
        void Create(T item);
        T Retrieve(int id);
        void Update(int id, T updatedItem);
        void Delete(int id);
        List<T> GetAll();
    }
}
