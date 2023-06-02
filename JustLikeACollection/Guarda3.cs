using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustLikeACollection
{
    public class Guarda3<T> : IEnumerable<T>
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

        public IEnumerator<T> GetEnumerator()  
        {  
            foreach (T o in vars)  
            {  
                yield return o;  
            }  
        }

        //IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        } 
        public void Add(T item)
        {
            T temp = default;
            for(int i = 0; i < vars.Count();i++)
            {
                if(Equals(temp, vars[i]))
                {
                    vars[i] = item;
                    break;
                }
                    
            }
        } 
    }
}