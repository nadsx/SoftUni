using System;
using System.Collections.Generic;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> list;

        public Box()
        {
            this.list = new List<T>();
        }

        public int Count => this.list.Count;

        public void Add(T element)
        {
            this.list.Add(element);
        }

        public T Remove()
        {

            if(this.list.Count == 0)
            {
                throw new InvalidOperationException("Cannot remove from an empty box.");
            }

            var lastElement = this.list[this.list.Count - 1];
            this.list.RemoveAt(this.list.Count - 1);

            return lastElement;
        }
    }
}
