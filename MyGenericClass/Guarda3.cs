using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGenericClass
{
    public class Guarda3<T>
    {
        private T[] vars;
        public Guarda3()
        {
            vars = new T[3];
        }
        public T GetItem(int i)
        {
            if(CheckI(i))
            {
                return vars[i];
            }
            else
                throw new IndexOutOfRangeException();
        }
        public void SetItem(int i , T item)
        {
            if(CheckI(i))
            {
                vars[i] = item;
            }
            else
                throw new IndexOutOfRangeException();
        }

        private bool CheckI(int i){
            if(i<0 || i>2)
                return false;
            else
                return true;
        }
    }
}