using System.Collections.Generic;

namespace HowManyOfThisType
{
    public static class Checker
    {
        public static int HowManyOfType<T>(IEnumerable<object> items)
        {
            int n=0;
            foreach(object ob in items){
                if(ob is T) n++; 
            }
            return n;
        }
    }
}