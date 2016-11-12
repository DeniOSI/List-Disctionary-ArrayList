using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndCollection
{
    class ListSS : IComparable, IEqualityComparer<ListSS>, IComparer<ListSS>
    {



        

   
        public string Name { get; set; }
        public int Age { get; set; }

        public ListSS()
        {
            
        }

        public ListSS(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
      
        public override string ToString()
        {
            return string.Format(Name + " " + Age);
        }

        public int CompareTo(object obj) //реализация метода для сортировки и сравнения
        {
            ListSS ls;
            if (obj==null)
            { return 0; }
            ls = obj as ListSS;
            if (this.Name.CompareTo(ls.Name)==1)
                return 1;
            return -1;

        }

        public bool Equals(ListSS x, ListSS y)
        {
            if(x ==null || y == null) return false;
            if ((x.Age != y.Age) || (x.Name != y.Name)) return false;
            return true;
        }

        public int GetHashCode(ListSS obj)
        {
            throw new NotImplementedException();
        }

        public int Compare(ListSS x, ListSS y)
        {
            if (x == null)
            {
                if (y == null)
                    return 0;
                else
                    return -1;
            }
            else

                if (y == null)
                return 1;
            else
                if ((x.Age == y.Age) & (y.Name.CompareTo(x.Name) == 0))
            {
                return 0;
            }
            else return -1;

        }
    }
}
