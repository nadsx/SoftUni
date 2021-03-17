using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random random = new Random();

        public RandomList()
        {
            this.List = new List<string>();
        }

        public List<string> List { get; set; }

        public string RandomString()
        {
            int elementIndex = random.Next(0, this.List.Count);

            string element = this.List[elementIndex];
            this.List.RemoveAt(elementIndex);

            return element;
        }
    }
}
