using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST150W5A10
{
    internal class Set
    {
        private List<int> elements;

        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }

        // Corrected by Adonis S. Deliannis
        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    return true;
                // This immediately returns the function when all we care about is when a match is found.
                // else
                //     return false;
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }


        // Corrected by Adonis S. Deliannis
        public Set union(Set rhs)
        {
            // No deep copy was performed. Essentially a reference was still passed to A,
            // even though a new class was passed, reference to A's elements to s's elements.

            Set s = new();
            s.elements = elements.Select(x => x).ToList();

            for (int i = 0; i < rhs.elements.Count; i++)
            {
                s.addElement(rhs.elements[i]);
            }
            s.elements.Sort();
            return s;
        }
    }
}

