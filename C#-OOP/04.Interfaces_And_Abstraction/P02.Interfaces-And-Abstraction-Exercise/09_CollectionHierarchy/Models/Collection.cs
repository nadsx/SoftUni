namespace CollectionHierarchy.Models
{
    using Contracts;

    using System.Collections.Generic;

    public abstract class Collection : IAddCollection
    {
        protected Collection()
        {
            this.DataCollection = new List<string>();
        }

        protected List<string> DataCollection { get; }

        public virtual int Add(string item)
        {
            this.DataCollection.Insert(0, item);

            return 0;
        }
    }
}