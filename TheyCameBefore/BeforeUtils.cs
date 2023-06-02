using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>
        (IEnumerable<T> items, T item) where T : IComparable<T>
        {
            foreach(T i in items)
            {
                int comparison = i.CompareTo(item);
                if(comparison<0) yield return i;
            }
        }
    }
}