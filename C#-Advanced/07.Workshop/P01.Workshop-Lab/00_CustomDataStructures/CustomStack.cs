using System;

namespace _00_CustomDataStructures
{
    public class CustomStack
    {
        private const int InitialCapacity = 4;
        private int[] items;
        private int count;

        public CustomStack()
        {
            this.count = 0;
            this.items = new int[InitialCapacity];
        }

        public int Count 
        {
            get
            {
                return this.count;
            }
        }

        public void Push(int element)
        {
            Resize();

            this.items[this.count] = element;
            this.count++;
        }

        public int Pop()
        {
            ThrowExceptionWhenEmpty();
            var lastElement = this.items[this.count - 1];
            this.count--;

            return lastElement;
        }

        public int Peek()
        {
            ThrowExceptionWhenEmpty();
            return this.items[this.count - 1];
        }

        public void ForEach(Action<int> action)
        {
            for (int i = this.count - 1; i >= 0; i--)
            {
                action(this.items[i]);
            }
        }

        private void ThrowExceptionWhenEmpty()
        {
            if(this.count == 0)
            {
                throw new Exception("Stack is empty.");
            }
        }

        private void Resize()
        {
            if (this.items.Length > this.Count)
            {
                return;
            }

            int[] tempArray = new int[2 * this.items.Length];
            //Array.Copy(this.items, 0, tempArray, 0, this.items.Length);

            for (int i = 0; i < this.items.Length; i++)
            {
                tempArray[i] = this.items[i];
            }

            this.items = tempArray;
        }
    }
}
