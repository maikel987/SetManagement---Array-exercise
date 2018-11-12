using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Set
    {
        private bool[] array = new bool[1001];

        public Set()
        {

        }
        public Set(params int[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                array[args[i]] = true;
            }
        }

        public void Union(Set sec)  // Union des deux
        {
            for (int i = 0; i < sec.array.Length; i++)
            {
                array[i] = array[i] || sec.array[i];
            }
        }
        public void Intersect (Set sec)  // Intersection des deux
        {
            for (int i = 0; i < sec.array.Length; i++)
            {
                array[i] = array[i] && sec.array[i];
            }
        }

        public bool Subset (Set sec) 
        {
            bool flag = true;
            for (int i = 0; i < sec.array.Length; i++)
            {
                if (sec.array[i]) flag = flag && array[i];
            }
            return flag;
        }

        public bool IsMember(int member)
        {
            return array[member];
        }

        public void Insert(int ins)
        {
             array[ins] = true;
        }

        public void Delete (int del)
        {
            array[del] = false;
        }

        public override string ToString()
        {
            string temps = null;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i])
                {
                    temps += string.Format("{0} ", i);
                }
            }
            return temps;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
                return false;
            bool flag = true;
            Set temp = (Set)obj;

            for (int i = 0; i < array.Length; i++)
            {
                flag = flag && (temp.array[i] == array[i]);
            }

            return flag;
        }
    }
}
