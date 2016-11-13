using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndCollection.StackBL
{
    public class StackS
    {
        public static string PrintStack(object obj)
        {
            string str=default(string);
            Stack st = obj as Stack;
            while(st.Count > 0)
            {
                str +=st.Pop()+ " ";
            }
            return str;
        }
    }
}
