using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1303_Project
{
    public class Storage<T> : InterfaceStorage<T>
    {
        private T[] data;
        private int currentIndex;
        private int growthFactor;

        public Storage(int size, int growthFactor)
        {
            data = new T[size];
            currentIndex = 0;
            this.growthFactor = growthFactor;
        }

        public void Create(T item)
        {
            if (currentIndex >= data.Length)
                ResizeArray();

            data[currentIndex++] = item;
        }

        public T Retrieve(int id)
        {
            if (id < 0 || id >= currentIndex)
                throw new IndexOutOfRangeException("Invalid index.");

            return data[id];
        }

        public void Update(int id, T updatedItem)
        {
            if (id < 0 || id >= currentIndex)
                throw new IndexOutOfRangeException("Invalid index.");

            data[id] = updatedItem;
        }

        public void Delete(int id)
        {
            if (id < 0 || id >= currentIndex)
                throw new IndexOutOfRangeException("Invalid index.");

            for (int i = id; i < currentIndex - 1; i++)
            {
                data[i] = data[i + 1];
            }

            data[currentIndex - 1] = default(T);
            currentIndex--;
        }

        public List<T> GetAll()
        {
            return data.Take(currentIndex).ToList();
        }

        private void ResizeArray()
        {
            int newSize = data.Length * growthFactor;
            T[] newData = new T[newSize];
            Array.Copy(data, newData, data.Length);
            data = newData;
        }
    }

}
