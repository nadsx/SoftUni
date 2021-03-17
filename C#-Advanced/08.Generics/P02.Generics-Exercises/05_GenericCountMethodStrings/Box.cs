using System;
using System.Collections.Generic;
using System.Text;

namespace _05_GenericCountMethodStrings
{
    public class Box<T>
        where T : IComparable<T>
    {
        public Box()
        {
            this.Values = new List<T>();
        }

        public List<T> Values { get; set; }

        public int CountGreater { get; private set; }

        public void Compare(T item)
        {
            foreach (var currentItem in this.Values)
            {
                if (currentItem.CompareTo(item) > 0) //-1 0 1 
                {
                    this.CountGreater++;
                }
            }
        }

        public void Swap(int a, int b)
        {
            bool isInRange = a >= 0 && a < this.Values.Count && b >= 0 && b < this.Values.Count;

            if (!isInRange)
            {
                throw new InvalidOperationException("Values are not in range!");
            }

            T tempValue = this.Values[a];
            this.Values[a] = this.Values[b];
            this.Values[b] = tempValue;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var element in this.Values)
            {
                sb.AppendLine($"{element.GetType().FullName}: {element}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
