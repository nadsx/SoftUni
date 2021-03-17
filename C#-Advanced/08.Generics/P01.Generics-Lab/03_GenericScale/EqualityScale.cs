using System;

namespace GenericScale
{
    public class EqualityScale<T>
    {
        public EqualityScale(T left, T right)
        {
            this.Left = left;
            this.Right = right;
        }

        public T Left { get; }

        public T Right { get; }


        public bool AreEqual()
        {
            return this.Left.Equals(this.Right);
        }
    }
}
