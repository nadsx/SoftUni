namespace CollectionHierarchy.Models
{
    using Contracts;

    public class AddRemoveCollection : Collection, IRemoveCollection
    {
        public virtual string Remove()
        {
            string lastItem = this.DataCollection[this.DataCollection.Count - 1];
            this.DataCollection.RemoveAt(this.DataCollection.Count - 1);

            return lastItem;
        }
    }
}
